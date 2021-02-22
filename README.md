


dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\CoffeeAPI.pfx -p pa55w0rd!
dotnet dev-certs https --trust

dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\TeaAPI.pfx -p pa55w0rd!
dotnet dev-certs https --trust

les certificats sont dans : C:\Users\USERPROFILE\.aspnet\https 

(In Tea csproj folder)
dotnet user-secrets set "Kestrel:Certificates:Development:Password" "pa55w0rd!"

(In Coffee csproj folder)
dotnet user-secrets set "Kestrel:Certificates:Development:Password" "pa55w0rd!"

(in envoy folder)
docker build -t envoygateway .

une fois build :

docker run -p 9901:9901 -p 10000:10000 envoygateway

(in project folder) 
docker-compose up --build

