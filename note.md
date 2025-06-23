# 📚 gomokuLiveGame 项目笔记

本项目基于 .NET 8 和 ASP.NET Core 构建，使用 Docker 与 Docker Compose 进行容器化部署。以下是项目中各个目录和文件的作用说明，便于理解项目结构和后续开发。

---

## 📁 目录结构说明

```txt
.
├── bin/                         # 编译输出文件夹（Debug/Release 二进制）
│   └── Debug/net8.0/           # 针对 .NET 8 的调试构建输出
│
├── docker-compose.yml          # Docker Compose 启动配置文件，管理服务、端口等
├── Dockerfile                  # 构建 ASP.NET Core 应用 Docker 镜像的脚本
│
├── gomokuLiveGame.csproj       # .NET 项目配置文件，定义依赖、目标框架等
├── gomokuLiveGame.sln          # Visual Studio 的解决方案文件，组织项目结构
│
├── obj/                        # 构建中间文件缓存目录（无需手动修改）
│   └── Debug/net8.0/
│       ├── gomokuLiveGame.*    # 当前项目生成的中间编译文件
│       ├── MyAspNetApp.*       # 旧项目文件编译残留（可删除）
│       ├── ref/, refint/       # 编译引用缓存目录
│       └── staticwebassets/    # 静态文件目录（仅页面类项目会使用）
│
├── Program.cs                  # 应用程序的入口文件，定义请求处理逻辑
├── README.md                   # 简要项目说明（非技术文档）
└── note.md                     # 🔍 当前笔记文件，记录学习过程与项目结构说明
