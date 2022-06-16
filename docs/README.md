
## MIGRATION
1 - Setar o projeto de Infra.Dados como principal a ser executado

2- Pelo PowerShell, entrar na pasta do projeto TesteKeyworks.Cadastros.Infra.Dados

3 - Executar o comando abaixo para setar o Ambiente em que deseja fazer o Migration
$Env:ASPNETCORE_ENVIRONMENT = "Development"

4 - Então, executar o comando abaixo para gerar o Migration, de acordo com o ambiente setado anteriormente
dotnet ef migrations add development --context DbKeyworks -s C:\dev\Estudos\back\TesteKeyworks\src\TesteKeyworks.WebApp.MVC --verbose

5 - Após a geração do Migration, executar o comando abaixo para atualizar a DataBase
dotnet ef database update --context DbKeyworks -s C:\dev\Estudos\back\TesteKeyworks\src\TesteKeyworks.WebApp.MVC --verbose

## DOCKER
## Criar uma rede especial em modo bridge
docker network create --gateway 172.18.0.1 --subnet 172.18.0.0/16 dev-local

## Criar o volume
docker volume create pg-keyworks

## Executar o container do Postgres para o WebApp Keyworks
docker run -ti --network=dev-local --ip 172.18.0.176 -p 5432:5432 --name pg-keyworks -e "POSTGRES_PASSWORD=123456" -v /var/lib/docker/volumes/pg-keyworks/_data:/var/lib/postgresql/data -d postgres


