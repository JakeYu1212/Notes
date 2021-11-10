import random
from math import *
from numpy import *

length = 120
width = 120

def generateDots(length, width, dotsNum):
    dotsList = []
    for i in range(dotsNum):
        dotsList.append((random.random() * length, random.random() * width))
    return dotsList

def calculateDis(dot1, dot2):
    return sqrt(pow(dot1[0] - dot2[0],2) + pow(dot1[1] - dot2[1],2))

def generateMinDis(dotsList):
    minDisList = []
    for dot1 in dotsList:
        dot1DisList = []
        for dot2 in dotsList:
            if dot1 != dot2:
                dot1DisList.append(calculateDis(dot1, dot2))
        dot1MinDis = min(dot1DisList)
        minDisList.append(dot1MinDis)
    return minDisList

def testFunc(testTimes, dotsNum):
    for i in range(testTimes):
        meanList = []
        dotsList = generateDots(length, width, dotsNum)
        minDisList = generateMinDis(dotsList)
        meanList.append(mean(minDisList))
    return mean(meanList)

print(testFunc(10000,50))
print(testFunc(10000,4))

