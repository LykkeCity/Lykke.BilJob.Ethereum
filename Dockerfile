FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY . .
ENTRYPOINT ["dotnet", "Lykke.BilJob.Ethereum.dll"]