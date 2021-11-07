# 排行榜技术文档
## 整体框架：
- 1:先通过提供的json文件读取数据并创建对象，在创建排行榜的时候解析这些数据成为他们的属性。
- 2:通过json给的数据判断需要创建的预置物。
- 3:导入美术资源
- 4:根据需求文档确定整个UI的层级和结构。
- 5:根据需求文档实现具体的功能并测试

## 目录结构：

```

├── Readme.md             #技术文档                    
├── config                     
│   ├── SimpleScence      #场景
├── internal
│   ├── Read  #读取配置文件
│   ├── JsonController        #数据类
│   ├── BasicListAdapter  #复用模版
│   |    ├── pkg   
│   |    ├── ├── OSA   
│   |    ├── ├── SimepleJson

```



## 层级分析：
- 入口按钮（button）打开整个排行榜，分为上面的倒计时界面和下面的排行滚动视图（OSAviewport),在滚动视图里显示排行榜的所有内容

```
├── MainCamera
├── JsonController              #读取数据
├── ButtonEvent                  #点击事件
├── Canvans
│   ├── OpenButton
│   ├── CloseButton	
│   ├── OSA                      #排行榜
│       ├── Content		
│           ├── content
│           ├── BasicListAdapter #UI模版

```

## 第三方库
- 1:Simplejson:用于解析json文件
- Assets/Function1/01.Plugins/SimpleJSON.cs
- 2:OSA：用于复用ui
- Assets/Function1/02.Materals/资源/OSA

## 代码：
| 需要的脚本       |     实现的功能 |
| ------ | ------                |
| 读取数据脚本 |  读取和解析json的脚本  |
| 倒计时协程 |  每秒更新一次模拟时间流动   |
| 控制排行榜脚本   |  控制排行榜内容更新和复用的脚本   |


![排行榜](https://user-images.githubusercontent.com/92706401/140605711-408573cb-ee37-40dc-b72e-cb9f29f0dfb8.png)
