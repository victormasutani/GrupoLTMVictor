Projeto criado no VS 2017 e SQL Server 2014+

- Criar uma database no SQL Server chamada "GrupoLTMVictor"

- Abrir "SLN" do projeto e restaurar os pacotes NuGet
	
- Alterar string de conexão nos arquivos para o servidor SQL Server que possuir a nova database "GrupoLTMVictor":

	GrupoLTM.Migration -> migration-up.bat
	GrupoLTM.Migration -> migration-down.bat
	GrupoLTM.WebApi -> web.config

- Compilar o projeto GrupoLTM.Migration

- No deploy gerado pelo projeto GrupoLTM.Migration, executar "migration-up.bat" para realizar a criação da estrutura e dados do banco de dados.

- Executar simultaneamente os dois projetos 

	GrupoLTM.WebApi
	GrupoLTM.Web
	
- Caso a porta da API seja trocada, alterar no arquivo

	GrupoLTM.Web -> wwwroot/app.js
	
	Linhas: 55 e 63
	
- Para se logar utilize admin/admin

- É possível inserir outros usuários, a tabela é: GrupoLTMVictor.USERAPP