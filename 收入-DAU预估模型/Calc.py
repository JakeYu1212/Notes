import numpy as np
import xlwings as xw
import pandas as pd
from datetime import datetime, date, time

def caculate_dau(excel_file_name):

    wb = xw.Book(excel_file_name)

    main_data = pd.read_excel(excel_file_name, '模拟计算', index_col=None, na_values=['NA'])
    retain_data = pd.read_excel(excel_file_name, '留存衰减曲线', index_col=None, na_values=['NA'])
    date_series = np.array(main_data['日期'])
    new_users = np.array(main_data['新注册'])
    retain_curve = np.array(main_data['留存曲线'])

    day_num = len(date_series)
    estimate_dau = np.array([0.0] * day_num)

    for i in range(day_num):
        retain_series = np.array(retain_data['Rate' + str(retain_curve[i])])[0:i+1]
        retain_series_invert = retain_series[::-1]
        retain_num = new_users[0:i+1] * retain_series_invert
        estimate_dau[i] = retain_num.sum()

    title = '预估DAU[' + str(date.today()) + ']'
    wb.sheets[0].range('D1').value = title
    wb.sheets[0].range('D2').options(transpose=True).value = estimate_dau

# caculate_dau('Z3收入预估.xlsx')

def caculate_monthday(indatetime):
    if indatetime.month < 12:
        a = datetime.combine(date(indatetime.year, indatetime.month, 1), indatetime.time())
        b = datetime.combine(date(indatetime.year, indatetime.month + 1, 1), indatetime.time())
        return (b - a).days
    else:
        return 31


def caculate_mau(excel_file_name):

    wb = xw.Book(excel_file_name)

    main_data = pd.read_excel(excel_file_name, '模拟计算', index_col=None, na_values=['NA'])
    retain_data = pd.read_excel(excel_file_name, '留存衰减曲线', index_col=None, na_values=['NA'])
    date_series = np.array(main_data['日期'])
    new_users = np.array(main_data['新注册'])
    retain_type = np.array(main_data['留存曲线'])

    # count all the month
    month_series = np.arange(date_series[0], date_series[len(date_series) - 1], dtype='datetime64[M]')
    month_series_datetime = pd.to_datetime(month_series)
    date_series_datetime = pd.to_datetime(date_series)
    day_num = len(date_series)
    month_num = len(month_series_datetime)
    estimate_mau = np.array([0.0] * month_num)

    # This method misses the players that did not login at 2nd day, but login at 3rd day or later, so the mau will be less, but the error is torable
    for i in range(month_num):
        for j in range(day_num):
            if datetime.date(date_series_datetime[j]).replace(day=1) > datetime.date(month_series_datetime[i]).replace(day=1):
                break
            if datetime.date(date_series_datetime[j]).replace(day=1) < datetime.date(month_series_datetime[i]).replace(day=1):
                retain_type_j = retain_type[j]
                retain_daynum = (month_series_datetime[i] - date_series_datetime[j]).days
                retain_rate = retain_data['Rate' + str(retain_type_j)][retain_daynum]
                estimate_mau[i] = estimate_mau[i] + new_users[j] * retain_rate
            if datetime.date(date_series_datetime[j]).replace(day=1) == datetime.date(month_series_datetime[i]).replace(day=1):
                estimate_mau[i] = estimate_mau[i] + new_users[j]
        
        wb.sheets['月活跃'].range('A2').options(transpose=True).value = month_series
        wb.sheets['月活跃'].range('B2').options(transpose=True).value = estimate_mau

caculate_mau('Z3收入预估.xlsx')


