FROM mcr.microsoft.com/dotnet/core/sdk as publish
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o out PizzaStore.Client/PizzaStore.Client.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet
WORKDIR /dist
COPY --from=build /app/out /dist

CMD ["dotnet", "PizzaStore.Client.dll"]