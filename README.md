# TaskManagerAPI
<div>
  <h2>🎯Objetivo:</h2>
  <p>Como um projeto acadêmico, tem por objetivo disponibilizar uma API Rest para gerenciar tarefas.</p>
</div>
<div>
  <h2>💻 Tecnologias Utilizadas:</h2>
  <ul>
    <li>Projeto: .NET Core WebAPI</li>
    <li>ORM: .NET Entity Framework</li>
    <li>Arquitetura em Camadas</li>
    <li>Patterns Repository / Service</li>
    <li>Pattern Response Wrapper (Envelope de Resposta) padronizado</li>
    <li>DTOs</li>
    <li>DI - Dependence Inversion - Inversão de dependência</li>
    <li>IoC - Inversion of Control - Inversão de Controle</li>
    <li>Banco de dados <em>InMemory</em></li>
  </ul>
</div>
<div>
  <h2>✅ Requisitos: </h2>
  <ul>
    <li>Git</li>
    <li>.NET 9.0</li>
  </ul>
</div>
<div>
  <h2>⚙️ Como rodar:</h2>
  <ul>
    <li>Clonar o repositório em uma pasta, através do comando:
        <p><em><code>git clone https://github.com/oliveira-alexander/TaskManagerAPI</code></em></p>
    </li>
    <li>Navegar até a pasta do projeto onde está o arquivo <em>TaskManagerAPI.csproj</em> através do console</li>
    <li>Realizar o seguinte comando para executar a API:
      <p><em><code>dotnet run</code></em></p>
    </li>
    <li>Mantendo o console aberto com a API executando, no navegador de sua preferência, acessar o endereço:
        <p><em><code>http://localhost:5058/scalar/v1</code></em></p>
    </li>
  </ul>
</div>
<div>
  <h2>🛣️ Endpoints:</h2>
  <p>Os endpoits disponíveis e suas utilizações são os seguintes:</p>
  <ul>
    <li>
      <p><strong>/api/Task/Create<strong></p>
      <p><strong>Método:</strong> POST</p>  
      <p>Disponibiliza a criação de tarefas</p>
    </li>
    <li>
      <p><strong>/api/Task/GetTasks<strong></p>
      <p><strong>Método:</strong> GET</p>  
      <p>Obtém todas as tarefas já criadas</p>
    </li>
    <li>
      <p><strong>/api/Task/GetTaskById{Id}<strong></p>
      <p><strong>Método:</strong> GET</p>  
      <p>Obtém a tarefa do Id informado</p>
    </li>
    <li>
      <p><strong>/api/Task/Delete{id}<strong></p>
      <p><strong>Método:</strong> DELETE</p>  
      <p>Remove a tarefa do Id informado </p>
    </li>
    <li>
      <p><strong>/api/Task/Edit<strong></p>
      <p><strong>Método:</strong> PUT</p>  
      <p>Altera os dados da tarefa informada</p>
    </li>
  </ul>
  <div>
    <h2>📤 Respostas / Responses:</h2>
    <p>As respostas às requisições são feitas com um envelope padrão, contendo os seguintes campos:</p>
    <ul>
      <li>
        <p>Sucesso:</p>
        <p>Tipo: Bool</p>
        <p>Informa sucesso ou erro na requisição</p>
      </li>
      <li>
        <p>Mensagem:</p>
        <p>Tipo: String</p>
        <p>Informa uma mensagem de erro se houver</p>
      </li>
      <li>
        <p>Dados:</p>
        <p>Tipo: JSON</p>
        <p>Retorna dados quando solicitado</p>
      </li>
    </ul>
  </div>
</div>

