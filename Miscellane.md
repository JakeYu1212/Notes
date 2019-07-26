
##### 60s射击次数计算公式

-半自动装弹:
$$
\frac{60 - (弹夹容量 - 1)*射击间隔}{单发时间} + 弹夹容量
$$
-弹夹装弹:
$$
\left[ \frac{60 - (弹夹容量 - 1)*射击间隔}{弹夹时间 + (弹夹容量 - 1)*射击间隔} + 1  \right]*弹夹容量
$$
-单发/自动装弹:
$$
\frac{60}{射击间隔} + 弹夹容量
$$

#### 战斗公式：

$$
造成伤害 = 坦克攻击力* \frac{f(穿透,距离)}{敌方装甲} * 敌方部位伤害系数
$$

​									**穿透和距离的关系：**

![1562670738076](C:\Users\75235\AppData\Roaming\Typora\typora-user-images\1562670738076.png)

##### 泊松分布:

$$
P(X = k) = \frac{\lambda^{k}}{k!}e^{-\lambda},\, k=0,1,...
$$



##### Conway's law:

> organizations which design systems ... are constrained to produce designs which are copies of the communication structures of these organizations.



##### Dunbar's number:

> Dunbar's number is a suggested cognitive limit to the number of people with whom one can maintain stable social relationships—relationships in which an individual knows who each person is and how each person relates to every other person. It has been proposed to lie between 100 and 250, with a commonly used value of 150.



$$
\frac{坦克当前速度}{坦克最大行进速度} * (aimingSpeedMaxSpeed - aimingSpeed) + aimingSpeed
$$

