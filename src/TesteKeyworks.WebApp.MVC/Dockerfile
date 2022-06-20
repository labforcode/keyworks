FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS http://+:80
ENV ASPNETCORE_ENVIRONMENT: "Development"
ENV TZ=America/Sao_Paulo

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TesteKeyworks.WebApp.MVC/TesteKeyworks.WebApp.MVC.csproj", "src/TesteKeyworks.WebApp.MVC/"]
COPY ["src/TesteKeyworks.Cadastros.Servicos/TesteKeyworks.Cadastros.Servicos.csproj", "src/TesteKeyworks.Cadastros.Servicos/"]
COPY ["src/TesteKeyworks.Cadastros.Dominios/TesteKeyworks.Cadastros.Dominios.csproj", "src/TesteKeyworks.Cadastros.Dominios/"]
COPY ["src/TesteKeyworks.Cadastros.Dominios.Core/TesteKeyworks.Cadastros.Dominios.Core.csproj", "src/TesteKeyworks.Cadastros.Dominios.Core/"]
COPY ["src/TesteKeyworks.Cadastros.Infra.Dados/TesteKeyworks.Cadastros.Infra.Dados.csproj", "src/TesteKeyworks.Cadastros.Infra.Dados/"]
COPY ["src/TesteKeyworks.Cadastros.Infra.CrossCutting/TesteKeyworks.Cadastros.Infra.CrossCutting.csproj", "src/TesteKeyworks.Cadastros.Infra.CrossCutting/"]
COPY ["src/TesteKeyworks.Cadastros.Infra.Util/TesteKeyworks.Cadastros.Infra.Util.csproj", "src/TesteKeyworks.Cadastros.Infra.Util/"]

RUN dotnet restore "src/TesteKeyworks.WebApp.MVC/TesteKeyworks.WebApp.MVC.csproj"
COPY . .
WORKDIR "/src/src/TesteKeyworks.WebApp.MVC"
RUN dotnet build "TesteKeyworks.WebApp.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TesteKeyworks.WebApp.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TesteKeyworks.WebApp.MVC.dll"]