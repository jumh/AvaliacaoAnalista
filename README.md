# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

* Codebase: O código base da aplicação deve ser único de modo que uma aplicação não deve possuir mais de um código fonte. Esse princípio não impede com que haja versões diferentes dependente do ambiente em que ele recebe o deploy (Dev, Hml, Prod).
Além disso, caso uma segunda aplicação seja semelhante, deve-se obter apenas a parcela de código necessária e não o todo. 

* Config: Cada ambiente pode (em alguns casos deve) possuir suas configurações próprias. Isso vale para que se preserve cada ambiente e etapada do desenvolvimento. Por exemplo: não devemos utilizar uma connectionstring de produção em um ambiente de desenvolvimento; se estamos com um projeto open-source, não devemos colocar informações próprias de cada utilizador do código (como uma API Key).

* Backing Services: É todo serviço que a aplicação consome. O objetivo é que esses serviços estejam desacoplados da aplicação principal, como um serviço de mensageria por exemplo.

* Parity: O código distribuido entre os ambientes (Dev, Hml e Prod) deve ser o mais semelhante possível. Isso se dá para que sejam garantidos alguns pontos:
  
  Agilizar o desenvolvimento, correção e melhoria do código fonte;
  Diminuir o tempo entre, desenvolvimento, QA e Deploy;
  Auxiliar para que novos desenvolvedores tenham confiança de um código estável entre os ambientes

* Build, Run, Release: Trata do momento em que o código é compilado e preparado para ser posto em seu devido ambiente. Além disso trata também do versionamento do código e das práticas de CI/CD;

* Admin Processes: Qualquer ativida que deve ser realizada apenas uma vez ou não remeta diretamente ao código. Por exemplo: executar uma Seed para uma primeira carga em um Db, Migração de dados, limpeza de dados que podem ocorrer periódicamente.




2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Camada de aplicação (Backend): onde a regra de negócio é aplica. Recebe e processa os dados necessários que serão apresentados na camada seguinte.

Camada de apresentação (Frontend): responsável por apresentar as informações ao usuário. Nessa camada onde os dados são recebidos para que sejam enviados ao Backend


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Arquitetura SOA: não me recordo do que se trata.

Arquitetura microserviços: a aplicação é dividida em diversos serviços que se comunicam entre si. Muito utilizada em grandes projetos onde existe a necessidade de escalabilidade de um módulo específico. 



4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Utilizarei POO como parâmetro para trazer as diferenaças.

Class são como modelos para criação de um objeto. Uma class possui propriedades e algumas dessas podem ser outras Class e até mesmo uma Struct. Vou utilizar uma Class Pessoa como exemplo:

public class Pessoa
{
    public string Nome { get; set; }        // Propriedade do tipo string (classe)
    public DateTime Idade { get; set; }     // Propriedade do tipo DateTime (struct)
    public string CPF { get; set; }         // Propriedade do tipo string (classe)
}

Struct são utilizados para representar dados mais simples e que não podem ser manipulados como um Datetime ou um Guid. 

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET é funciona apenas na plataforma Windows e é utilizado para construção de Windows Form e projeto MVC
Enquanto .NET Core é multiplataforma e mais voltado apra desenvolvimento de API.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
Não sei do que se trata o GRPC, mas é bem provavel que ele também seja um modelo de comunicação entre sistemas.

O REST é um modelo baseado no protoloco HTTP/HTTPS que é utilizado em APIs. Geralmente utilizamos JSON para essa troca de informação.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Um SPA utiliza das rotas para exibir determinado conteúdo na página. Se um projeto possui as rotas:
/home, /contato, /fale-conosco
na verdade o conteúdo de todas elas está na mesma pagina e o framework que será o responsável por verificar a rota e carregar o component/conteúdo necessário sem que a pagina seja recarregada.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é uma metodologia de desenvolvimento de software que reune ferramentas, equipes e etapas para que o mesmo seja efetuado.
Dentro do DevOps temos diversos processos como:
 - Planejamento das etapas de desenvolvimento;
 - Organização e distribuição de tarefas;
 - Controle das etapas de Deploy e entregas;
 - Alinhamento e organização de equipes.


10. Explique sobre um método agile.

**Resposta:**
Método Agile é voltado para entrega rápida de demandas em que existe uma comunicação mais direta com o cliente ao qual se destina a aplicação. É um modelo colaborativo, onde as demandas são distribuidas entre equipes. 
Além disso existem alguns ritos que são seguidos como:
 - Daily
 - Sprint
 - Planning
 - Sprint Review

O Core desse modelo de trabalho é a agilidade, de modo que até esses ritos não devem tomar mais tempo do que o necessário.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI - Continuous Integration: trata de realizar integrações continuas e frequentes do código. O Código fica armazenado em um repositório (como Azure DevOps Repos por exemplo) e sempre que um commit é enviado uma pipeline é ativada.
CD - Continous Delivery: trata da entrega do código que foi previamente enviado, testado e aprovado na pipeline no momento do CI de forma automatica. O CD não precisa necessariamente ocorre em Produção, visto que existem outros possíveis ambientes como Dev e Hml por exemplo.

A principal ferramenta para CI/CD são as pipelines. Elas são utilizadas para automatizar etapas e processos préviamente configurados e que são executas quando ocorre uma atualização na branch para a qual foi configurada.
Dentre uma das ações estão: Testes automatizados, Análise de código, Build e Deploy.
Algumas pipelines podem realizar o Swap de um ambiente de Pre para Prod.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Em resumo: Docker é a ferramenta e container é um conceito/modelo.

O Docker é a ferramenta utilizada para gerenciar os containers, deste a criação e execução até no versionamento.

O Container é utilizado para "empacotar" uma aplicação com tudo o que ela precisa para que seja executa. Em um Container para um projeto Angular por exemplo, ela vai armazenar exatamente a versão do Node, do Angular e todo NPM necessário para sua execução.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Não conheco Openshift.

Kubernetes é utilizado para gerenciar os containers que o Docker cria.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

Vantagens:
 - Reutilização em N sistemas;
 - Fácil escalabilidade quando estão distribuidas entre serviços;
 - Facilita a comunicação entre sistemas;
 - Pode utilizar autenticação JWT
 - Entrega apenas as informações solicitadas.

Desvantagens:
 - Se mal construida pode ser extremamente lenta e consumir muita memória do servidor alocado;
 - Passíveis de ataques DDoS e SQL Injection;
 - Funcionam apenas com HTTPS;
 - Pode informar mais do que deve caso não tenha sido bem configurada;

A principal preocupação na construção das APIs é a segurança. Devemos sempre declarar exatamente o que precisamos para executar o código e retornar sempre o mínimo possível para o cliente.
Caso necessário, criar serviços para obter IDs sem que haja necessidade de informar na requisição. 
Sempre utilizar ferramentas e pacotes confiáveis e seguros, evitando ao máximo Libs desconhecidas.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
 - Garantir que existe autenticação via JWT ou API Key;
 - Sempre que possível ter um tipo de Autorização;
 - Evitar requisição de fontes desconhecidas, tratando as fontes conhecidos no CORS;

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Comunicação assíncrona entre sistemas. O principal uso é para desacoplar sistemas e melhorar a escalabilidade e desempenho deles.
Em uma aplicação de comércio por exemplo:
Um sistema enviar uma mensagem PedidoRecebido e os seriços da aplicação que foram configurado para ouvir essa mensagem recebem a devida informação.
A partir dai os serviços realização suas respectivas ações e a mensagem é removida (quando configurada para tal)

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Não possuo este conhecimento.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Não possuo este conhecimento.


19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

A empresa em que atuava possuia diversos projetos com panéis Administrativos (Dashboard). Para cada painél criavamos uma estrutura de Roles e Permissões. 
Toda vez que um novo sistemas era criado, essas estrutura também era criada e o controle dela ficava na aplicação principal. 

Visando diminuir a carga na aplicação, criei uma API em .NET 8 para gerenciar essas permissões e atualizar em tempo real para o usuário ao qual se destinava em N projetos. Utilizei o SignalR para realizar essas operações.

A lógica é aplicada em 3 camadas: API de Permissão com SignalR, Frontend e Backend do projeto em questão.

As etapas são:

- A instância do Frontend que tem o usuário X logado no sistema inicia uma comunição com o SignalR informando: UserId e Project

- O SignalR cria um grupo do projeto e adiciona o usuário;

- O Frontend passa a escutar o grupo que o SignalR criou;

- Sempre que as permissões de um usuário X forem atualizadas no backend a aplicação do projeto, ele irá enviar para o SignalR as permissões e o Id daquele usuário;

- O SignalR irá invocar o método que está sendo escutado pelo Frontend;

- O Frontend receberá as informações e atualizará as permissões em tempo real fornecendo ou revogando acessos. Além de recarregar a pagina para bloquear qualquer tipo de acesso que ele possa ter perdido.

O principal desafio foi o tempo. Como era uma dor que poderia crescer a todo momento, desenvolvi essa solução em uma noite. Na manhã seguinte crie toda infra na Azure e a pipeline para o deploy, enviei para o QA e implementei no projeto que estava atuando no mento. O tempo total foi de 20h.