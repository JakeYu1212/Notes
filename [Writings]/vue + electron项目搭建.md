#1. 安装vue脚手架
我用的npm：
```
npm install -g @vue/cli
```
安装过vue-cli的需要先卸载：
```
npm uninstall vue-cli -g
```
还有一个坑，就是如果node版本太低，安装会失败。需要升级node版本。先安装n模块：
```
npm i -g n
```
再用n模块升级node：
```
sudo n stable
```
不加sudo会提示没有权限。stable代表稳定版本。

#2. 创建项目
在你想要的文件夹下执行命令：
```
vue create vueapp
```
就能创建成功了。

#3.配置electron
进入项目目录：
```
cd vueapp
```
通过以下命令调用electron-builder生成器：
```
vue add electron-builder
```

#4. 运行vue serve
执行：
```
npm run electron:serve
```
可以成功启动项目。

#5. 用vue build打包
也可以将你的项目打成一个可以安装的dmg包，执行以下命令：
```
npm run electron:build
```
但是这个打包的过程中会卡在下载electron的zip文件动不了，需要把下载地址改成淘宝镜像，操作步骤如下：
**1.执行前置命令**
```
npm config set registry https://registry.npm.taobao.org/ npm config set ELECTRON_MIRROR http://npm.taobao.org/mirrors/electron/
```
**2.修改/etc/bashrc文件**
在/etc/bashrc文件中，增加设置：
```
export ELECTRON_MIRROR=http://npm.taobao.org/mirrors/electron/
```
我不怎么会用vim，直接用VSCode改的，没啥问题，就是会有权限相关的提示。
修改保存以后，执行一下source命令使变量生效：
```
source /etc/barshrc
```
然后build就能成功了，可以看到项目里的dist_electron文件夹下面会有一个dmg文件，可以安装。

参考资料：
https://newsn.net/say/electron-mirror.html
https://zhuanlan.zhihu.com/p/335225253
https://cli.vuejs.org/zh/guide/prototyping.html
https://blog.csdn.net/guzhao593/article/details/81712016
https://cli.vuejs.org/guide/creating-a-project.html#vue-create