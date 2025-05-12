![image](https://github.com/user-attachments/assets/8be88c03-ff0b-4be6-83bc-fd629f1e7217)


<div>
  <h2>Objetivo</h2>
  <p>O TaskManagerAPI disponibiliza uma api para que sejam armazenadas tarefas <strong>em memória</strong> durante sua execução.</p>
</div>
<div>
  <h2>Como utilizar:</h2>
  <p>• Abrir o projeto em uma IDE compatível com C# e .NET Core, e realizar o debug.</p>
  <p>• No navegador, acessar "https://localhost:7033/scalar/v1" para acessar a API.</p>
</div>
<div>
  <h2>Endpoints</h2>
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
    <h2>Respostas / Responses:</h2>
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
        <p>Tipo: DTO</p>
        <p>Retorna dados quando solicitado</p>
      </li>
    </ul>
  </div>
  <div>
    <h2>Objetivos Futuros:</h2>
    <p>Estão sendo analisados objetivos de melhoria a serem implementados no projeto</p>
  </div>
</div>

