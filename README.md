# .NET 9 Web API 專案

這是一個使用 .NET 9 建立的 ASP.NET Core Web API 專案，展示了現代化的 API 開發方式。

## 📋 專案說明

本專案使用 .NET 9 的最新特性，包括：
- **Minimal API** - 簡潔的 API 端點定義
- **OpenAPI** - 標準化的 API 規格描述
- **Scalar UI** - 現代化的 API 文檔介面
- **Record Types** - 不可變的資料模型

## 🚀 快速開始

### 前置需求

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### 安裝與執行

1. **複製專案**
   ```bash
   git clone <repository-url>
   cd dotnet9
   ```

2. **進入專案目錄**
   ```bash
   cd app
   ```

3. **執行應用程式**
   ```bash
   dotnet run
   ```

4. **開啟瀏覽器訪問**
   - API 文檔: http://localhost:5189/scalar/v1
   - OpenAPI 規格: http://localhost:5189/openapi/v1.json
   - Weather API: http://localhost:5189/weatherforecast

## 📁 專案結構

```
dotnet9/
├── app/                          # Web API 專案
│   ├── Program.cs               # 主程式進入點
│   ├── app.csproj               # 專案檔
│   ├── appsettings.json         # 應用程式設定
│   ├── appsettings.Development.json  # 開發環境設定
│   └── Properties/
│       └── launchSettings.json  # 啟動設定
├── .gitignore                   # Git 忽略檔案
└── README.md                    # 專案說明文件
```

## 🔧 技術棧

- **.NET 9.0** - 最新的 .NET 框架
- **ASP.NET Core** - Web API 框架
- **Scalar.AspNetCore 2.14.14** - API 文檔工具
- **Microsoft.AspNetCore.OpenApi 9.0.16** - OpenAPI 支援

## 📚 API 端點

### GET /weatherforecast

取得未來 5 天的天氣預報資料。

**回應範例:**
```json
[
  {
    "date": "2026-06-09",
    "temperatureC": 25,
    "temperatureF": 77,
    "summary": "Warm"
  }
]
```

## 🛠️ 開發指令

```bash
# 還原相依套件
dotnet restore

# 建置專案
dotnet build

# 執行專案（開發模式）
dotnet run

# 執行專案（監看模式，自動重新載入）
dotnet watch run

# 發佈專案
dotnet publish -c Release
```

## 📦 套件管理

### 新增套件
```bash
dotnet add package <PackageName>
```

### 移除套件
```bash
dotnet remove package <PackageName>
```

### 更新套件
```bash
dotnet add package <PackageName> --version <Version>
```

## 🌐 環境設定

### 開發環境
- Port: 5189 (HTTP)
- 環境變數: Development
- 啟用: Scalar API 文檔、OpenAPI 端點

### 生產環境
需在 `appsettings.Production.json` 中設定：
- 連線字串
- 日誌等級
- CORS 政策
- 其他環境特定設定

## 🔍 Scalar API 文檔

專案使用 Scalar 作為 API 文檔工具，相較於傳統的 Swagger UI，Scalar 提供：
- ✨ 更現代化的介面設計
- 🚀 更好的效能表現
- 📱 響應式設計
- 🎨 深色模式支援
- 🔥 即時 API 測試功能

訪問 http://localhost:5189/scalar/v1 即可查看完整的 API 文檔。

## 📝 開發注意事項

1. **敏感資訊處理**
   - 不要在程式碼中硬編碼敏感資訊
   - 使用 `Environment.GetEnvironmentVariable()` 讀取環境變數
   - 敏感設定應放在 `.env` 檔案中（已列入 `.gitignore`）

2. **程式碼風格**
   - 使用 C# 命名慣例
   - 遵循 .NET 編碼規範
   - 啟用 Nullable 參考型別

3. **API 設計**
   - 遵循 RESTful 原則
   - 使用適當的 HTTP 狀態碼
   - 提供清楚的錯誤訊息

## 🐛 疑難排解

### 問題：HTTPS 重定向警告
```
Failed to determine the https port for redirect.
```
**解決方案:** 這是開發環境的正常警告，可以在 `launchSettings.json` 中設定 HTTPS 埠號。

### 問題：Port 已被占用
```
Address already in use
```
**解決方案:** 
1. 修改 `Properties/launchSettings.json` 中的 port 設定
2. 或關閉占用該 port 的程式

## 📖 學習資源

- [ASP.NET Core 官方文件](https://learn.microsoft.com/aspnet/core/)
- [.NET 9 新功能](https://learn.microsoft.com/dotnet/core/whats-new/dotnet-9)
- [Minimal APIs 指南](https://learn.microsoft.com/aspnet/core/fundamentals/minimal-apis)
- [Scalar 文檔](https://github.com/scalar/scalar)

## 👥 貢獻指南

歡迎提交 Issue 或 Pull Request！

## 📄 授權

此專案僅供教學使用。

---

**最後更新:** 2026-06-08