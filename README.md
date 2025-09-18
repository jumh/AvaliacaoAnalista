# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

Base de Código: Refere-se a uma base de código única, rastreada num sistema de controle de versão e utilizada para múltiplas implantações em diferentes ambientes.

Dependências: Todas as dependências de um aplicativo devem ser declaradas e isoladas, sem depender de bibliotecas ou ferramentas do sistema.

Configuração: As informações que variam entre os ambientes de implantação devem ser armazenadas no ambiente, não no código. Posso dar o exemplo no azure temos a opção de salvar as variaveis para cada ambiente

Serviços de Apoio: Todos os serviços de apoio de que o aplicativo precisa devem ser tratados como recursos anexados ao aplicativo, consumidos via rede através de uma URL, e conectados através de variáveis de ambiente.

Construir, Lançar, Executar: Os estágios de construção, lançamento e execução devem ser estritamente separados, sendo cada etapa independente. Por exemplo, as dependências são obtidas na fase de construção, e o código compilado é então lançado para ser executado. 

Processos: O aplicativo deve ser executado como um ou mais processos sem estado ("stateless"), que não armazenam dados localmente entre as requisições. Se for necessário armazenar dados, devem ser usados serviços de apoio, como um banco de dados, como descrito no fator anterior.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Seguindo um padrão de projeto DDD: Apresentação, Aplicação, Dominio e Infraestrutura.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

SOA é maior e centralizado, Microserviços é menor e indepedente.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

Ter mais segurança


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Struct é para objetos imutáveis e leves. Classe para modelos maiores e mais ricos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET é a versão mais recente do .NET Core. .NET 5 + Encerrou a divisão entre .NET Framework e .NET Core, unificando ambos sob um único nome: .NET. 


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST se baseia em recursos, usa formatos de texto (json) e é amplamente compatível, o gRPC é um framework de chamada de procedimento remoto (RPC), utiliza um formato binário e é otimizado para alta performance.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Não permite o carregamento da pagina toda. O front end intercepta a navegação e renderiza os componentes.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

Tenho conhecimento em Pipelines CI/CD, Git e etc... Objetivo: automação, colaboração e entrega contínua.


10. Explique sobre um método agile.

**Resposta:**

Scrum: Entregar valor continuamente e adptar as mudanças (quando necessário).

Kanban: Dar maior visibilidade do fluxo de trabalho.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI: integrar código continuamente, rodar testes e garantir qualidade.

CD: entregar em produção de forma automatizada.

Ferramentas: Git, Azure DevOps, GitHub Actions, Jenkins

12. Qual a diferença entre Docker e Containers.

**Resposta:**

Docker: Plataforma de criação e distribuição e execução de containers

Containers: Conceito de empcotamento, Isolamentos e Portabilidade

É correto afirmar que o Docker é uma plataforma que se baseia e utiliza containers para funcionar


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é um orquestrador de containers

OpenShift estende Kubernets para simplificar a implentação e gestão de aplicações em containers.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

Vantagens: Integração entre sistemas, escalabilidade e reuso.

Desvantagens: Risco de segurança, Versionamento, Dependêcia de terceiros...


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Autenticação JWT, OAuth2, Api Key. Criptografia HTTPS e TLS. Validação de entrada e saída. Loggin e monitoramento de acessos.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Desacoplar sistemas assincronamente. Garantir resiliência, tolerância a falhas.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

SAGA é um padrão de design para gerenciar transações distribuídas através de sequencia de transações. Permite tratar falhas atrave´s de execuções de transações compensatórias. 


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

Integração entre Kubernetes e Git. Basicamente é um repositorio onde permite que você versione e revise sua infraestrutura e aplicativos de forma semelhante ao seu código, além de implementar recursos de autoatendimento.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

- PIX: Com o objetivo de viabilizar o pagamentos instantâneos, foi realizada a integração com o banco Itaú. A principal importância desse projeto foi garantir a baixa do pagamento em até 30 minutos após a transação, proporcionando maior agilidade e praticidade aos clientes.
Tecnologias: .NET, Dapper, Testes Unitarios, RabbitMQ, Service BUS, Azure Devops (CI/CD), Sql Server e Mongo DB

- Link de Pagamento: Para oforecer maior comodidade aos cliente e diante de um cenário tão imprevisível (COVID-19), surgiu a necessidade de implantar o Link de Pagamento, integrado ao Gateway e Adquirentes. O projeto permetiu que os clientes realizassem a compra de acessórios e até mesmo de celulares nas lojas sem a necessidade de entrar nelas.
Tecnologias: .NET, Angular, React, Razor/Blazor, Dapper, Testes Unitarios, RabbitMQ, Service BUS, Azure Devops (CI/CD), Sql Server e Mongo DB