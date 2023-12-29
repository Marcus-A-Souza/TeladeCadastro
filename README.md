Fiz um CRUD uma tela de cadastro unsado visual studio, criei um projeto para armazenar dados de um cliente, como nome,idade,Email.
esse projeto ainda não esta finalizado, meu intuito é ao longo da semana acrescentar mais funçoes ao CRUD até deixalo bem robusto.
usei um  Framework do ASP.NET CORE, para desenvolver a aplicação.
comesei criando uma classe dentro da Model usando recursos como TABLE,COLUMN E DISPLAY para clriar minha tabela com as informações que desejo ter no crud.
depois criei o CONTEXTO atraves de uma classe contexto herdando Dbcontext para poder validar e filtrar os resultados da minha aplicação.
em seguida através do Duilder.services adicionei o Dbcontext e logo depois adicionei referencia da conexão com o banco de dados SQL server.
depois de feito isso executei o comando Controlador clicando com o direito encima do controller para gerar todos os controladores relacionado a minha aplicação.
e por ultimo e não menos importante fiz o mogration atraves do consoler do gerenciador de pacotes usando os comandos Add-migration inicial criacao-contex contexto e em seguida o Update-Database-context contexto para fazer toda a conexão da minha aplicação.
foi gerado esse CRUD.
