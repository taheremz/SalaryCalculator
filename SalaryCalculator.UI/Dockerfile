#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SalaryCalculator.UI/SalaryCalculator.UI.csproj", "SalaryCalculator.UI/"]
COPY ["SalaryCalculator.Contracts/SalaryCalculator.Contract.csproj", "SalaryCalculator.Contracts/"]
COPY ["SalaryCalculator.Infrustructure/SalaryCalculator.Infrustructure.csproj", "SalaryCalculator.Infrustructure/"]
RUN dotnet restore "SalaryCalculator.UI/SalaryCalculator.UI.csproj"
COPY . .
WORKDIR "/src/SalaryCalculator.UI"
RUN dotnet build "SalaryCalculator.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SalaryCalculator.UI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SalaryCalculator.UI.dll"]