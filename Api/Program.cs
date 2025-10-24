using MinimalApi; // garante que o namespace da API esteja acessível

var builder = WebApplication.CreateBuilder(args);

// Cria uma instância da classe Startup (onde está toda a configuração da API)
var startup = new Startup(builder.Configuration);

// Adiciona os serviços configurados no Startup
startup.ConfigureServices(builder.Services);

// Constrói o app
var app = builder.Build();

// Configura o pipeline (rotas, autenticação, etc.)
var env = app.Environment;
startup.Configure(app, env);

// Executa a aplicação
app.Run();