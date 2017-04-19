easy-note
=======================
简易的知识收集系统（模仿网易云笔记，加入自己的个性化功能）

整个项目计划包含三部分：

- [web-front](web-front) 使用 `Angular2` 开发的前端Web系统
- [backend-api](backend-api) 使用 `Node` 相关技术栈开发的后端API系统
- [client-app](client-app) 使用 `Electron + Angular2` 相关技术栈开发的客户端系统

# 如何开发

```bash
# clone project
git clone https://github.com/hstarorg/easy-note.git 

# develop web-front project
cd web-front
# install dependencies
npm i
# run
npm run dev
# run with hot reload
npm run dev:hot

# develop backend-api 
# enter folder, init dependencies and run
cd backend-api
npm i
npm run dev

# develop client-app
cd client-app
# waiting...
```