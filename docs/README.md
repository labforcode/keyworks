
## SOBRE

Projeto escrito com .AspNet vers�o 6, para backend e p�ginas Razor para frontend.

Sua divis�o consiste em um projeto WebApp com o c�digo HTML/CSS, criado um base em um template.

J� a parte de backend, possui a estrutura��o em camadas, em que se aplicou alguns dos conceitos de DDD, como o contexto delimitado e linguagem ub�qua.

As camadas s�o Servi�os, Dom�nio, Core, Infra-Data e Infra-CrossCutting;

Na camada de dom�nio, para o contexto de Cadastros, h� a entidade Cliente que norteia o cadastro e a atualiza��o, conforme especificado para a tela.

A camada de dom�nio Core cont�m o c�digo de suporte para o Dom�nio;

A Cadama de servi�o estabelece 'comunica��o' entre a Controller e o Dom�nio;

A infraestrutura na parte de dados cont�m os reposit�rios e o contexto de banco de dados, onde se aplicou o Code First, com Migration;

J� a camada de infraestrutura na parte de crosscutting cont�m as inje��es de depend�ncia;


Caso a aplica��o seja executada via VS, atentar para mudar o host do banco, no appsettings.development, para localhost. Caso exexute via container docker, ent�o, n�o h� necessidade de alterar.




## MIGRATION
1 - Setar o projeto de Infra.Dados como principal a ser executado

2- Pelo PowerShell, entrar na pasta do projeto TesteKeyworks.Cadastros.Infra.Dados

3 - Executar o comando abaixo para setar o Ambiente em que deseja fazer o Migration
$Env:ASPNETCORE_ENVIRONMENT = "Development"

4 - Ent�o, executar o comando abaixo para gerar o Migration, de acordo com o ambiente setado anteriormente
dotnet ef migrations add development --context DbKeyworks -s C:\dev\Estudos\back\TesteKeyworks\src\TesteKeyworks.WebApp.MVC --verbose

5 - Ap�s a gera��o do Migration, executar o comando abaixo para atualizar a DataBase
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

