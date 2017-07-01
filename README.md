# CoreDemo
ASP.NET CORE     EntityFramework Core     Mysql  CODEFIRST  IOC


vs2015 与vs2017 区别
1.最明显的区别就是在vs2015里面使用包管理配置project.json
  在vs2017又还原 vs原有的.csproj

1.EF与原来一样
 不过现在ef 是 Microsoft.EntityFrameworkCore 1.1.1
  数据驱动 MySql.Data.EntityFrameworkCore Install-Package MySql.Data.EntityFrameworkCore.Design -Version 6.10.1-beta -Pre
2.序列化 Newtonsoft.Json 还是一样

3.Microsoft.EntityFrameworkCore; 里面包含Include 方法

4.链接数据库字符 "Data Source=192.168.3.107;port=3306;Initial Catalog=car170622;user id=admin;password=7955178;Character Set=utf8;" providerName="MySql.Data.MySqlClient"

http://www.cnblogs.com/CreateMyself/p/6224141.html


vs2017出现的问题
1.不能添加area
2.默认没有controls view
  自己手动添加，但是手动添加的时候会出现问题，
  报错a.不能添加控制器 ，
  不能去引用Microsoft.Extensions.DependencyInjection.abstact 包

  VS2017新建控制器出现 No executable found matching command: dotnet-asp net-code generator解决办法
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="1.0.0-msbuild3-final" />
  </ItemGroup>
3.添加View时，
   当你新建了一个View文件夹时，
   在control添加视图的时候默认会添加到View文件夹下面


4.运行时
  1.Could not load file or assembly 'Microsoft.Extensions.DependencyInjection, Version=1.1.1.0, Culture=
  这个是说没有加载，包引用错误

 2. Unable to find the required services.
 Please add all the required services by calling 'IServiceCollection.AddMvc' inside the call to 'ConfigureServices(...)' in the application startup code.
  需要在startup 里面 ConfigureServices ，添加services.AddMvc();  

3.An error occurred during the compilation of a resource required to process this request. Please review the following specific error details and modify your source code appropriately.
   编译处理T所需的资源时出错 ，之前我View下面随便粘贴了一个视图，是不是没有加载进去导致出错的

4.乱码问题
 工具-扩展和更新，搜索插件"ForceUTF8",安装后源码文件会强制保存为带BOM的UTF-8。可能需要重新保存一下，但是只要保存文件的动作生效就会自动检测-转换编码

5.【关于MySql时间问题】
http://www.cnblogs.com/akini/archive/2013/01/30/2882767.html

AddColumn("Tests", "LastChanged", c => c.DateTime(nullable: false);
修改为
AddColumn("Tests", "LastChanged", c => c.DateTimeOffset(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP"));

http://www.linuxidc.com/Linux/2017-02/140766.htm?utm_source=tuicool
http://m.w2bc.com/article/243865


【迁徙数据库】
https://sanwen8.cn/p/4c1D0n0.html

在应用程序根目录按住shift键同时单击鼠标右键，选择“在此处打开命令窗口”，输入数据库迁移的命令
dotnet ef migrations add Init
dotnet ef database update

 使用程序包管理器控制台
 Add-Migration Init
 Update-Database

 打印数据库信息
Script-Migration -from 0


【所引用包】
MySql.Data.EntityFrameworkCore 6.10.1-beta
MySql.Data.EntityFrameworkCore.Design 6.10.1-beta
Microsoft.EntityFrameworkCore 1.1.2
Microsoft.EntityFrameworkCore.Design 1.1.2
Microsoft.EntityFrameworkCore.Relational 1.1.2
Microsoft.Extensions.Configuration.Json 1.1.1
【站点】
Microsoft.ApplicationInsights.AspNetCore 2.0.0
Microsoft.AspNetCore 1.1.2
Microsoft.AspNetCore.Mvc 1.1.3 
Microsoft.AspNetCore.StaticFiles 1.1.2
Microsoft.EntityFrameworkCore 1.1.2
Microsoft.EntityFrameworkCore.Design 1.1.2
Microsoft.EntityFrameworkCore.Relational 1.1.2
Microsoft.EntityFrameworkCore.Tools 1.1.0-preview4-final
Microsoft.Extensions.DependencyInjection 1.1.1
Microsoft.Extensions.Logging.Debug 1.1.2
Microsoft.VisualStudio.Web.BrowserLink 1.1.2
Microsoft.VisualStudio.Web.CodeGeneration.Design 1.1.1
MySql.Data 6.10.1-beta
MySql.Data.EntityFrameworkCore 6.10.1-beta
MySql.Data.EntityFrameworkCore.Design 6.10.1-beta



