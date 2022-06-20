
## SOBRE

Projeto escrito com .AspNet versão 6, para backend e páginas Razor para frontend.

Sua divisão consiste em um projeto WebApp com o código HTML/CSS, criado um base em um template.

Já a parte de backend, possui a estruturação em camadas, em que se aplicou alguns dos conceitos de DDD, como o contexto delimitado e linguagem ubíqua.

As camadas são Serviços, Domínio, Core, Infra-Data e Infra-CrossCutting;

Na camada de domínio, para o contexto de Cadastros, há a entidade Cliente que norteia o cadastro e a atualização, conforme especificado para a tela.

A camada de domínio Core contém o código de suporte para o Domínio;

A Cadama de serviço estabelece 'comunicação' entre a Controller e o Domínio;

A infraestrutura na parte de dados contém os repositórios e o contexto de banco de dados, onde se aplicou o Code First, com Migration;

Já a camada de infraestrutura na parte de crosscutting contém as injeções de dependência;


Caso a aplicação seja executada via VS, atentar para mudar o host do banco, no appsettings.development, para localhost. Caso exexute via container docker, então, não há necessidade de alterar.




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


## Docker Development
docker build -t keyworks/clientes -f src/TesteKeyworks.WebApp.MVC/Dockerfile .
docker push keyworks/clientes
docker pull keyworks/clientes
docker run -ti --network=dev-local --ip 172.18.0.56 --name keyworks-clientes -d -e ASPNETCORE_ENVIRONMENT=Development -p 3500:80 --rm keyworks/clientes

