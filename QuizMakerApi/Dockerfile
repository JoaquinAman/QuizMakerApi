#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

ENV MongoDbSettings__ConnectionString=mongodb+srv://diego:contrasena@videoform.4ctniww.mongodb.net/?retryWrites=true&w=majority

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["QuizMakerApi/QuizMakerApi.csproj", "QuizMakerApi/"]
COPY ["Dao.Mongo.Interface/Dao.Mongo.Interface.csproj", "Dao.Mongo.Interface/"]
COPY ["Dao.Mongo.Service/Dao.Mongo.Service.csproj", "Dao.Mongo.Service/"]
COPY ["Dao.Mongo.Entity/Dao.Mongo.Entity.csproj", "Dao.Mongo.Entity/"]
COPY ["Domain.Model/Domain.Model.csproj", "Domain.Model/"]
COPY ["Domain.Interface/Domain.Interface.csproj", "Domain.Interface/"]
COPY ["Domain.Service/Domain.Service.csproj", "Domain.Service/"]
RUN dotnet restore "QuizMakerApi/QuizMakerApi.csproj"
COPY . .
WORKDIR "/src/QuizMakerApi"
RUN dotnet build "QuizMakerApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QuizMakerApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QuizMakerApi.dll"]