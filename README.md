# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** 

**Code Base: O código fonte de um sistema deve estar versionado em um Repositório, para o controle de versões do mesmo.**

**Logs: A aplicação deve gerar os logs, porém, o armazenamento dos logs, é de responsabilidade do ambiente**

**Processos: A Aplicação deve rodar todos os processos sem depêndencia do estado local**

**Serviços de Apoio: API's, banco de dados e cache são considerados serviços externos dentro da nossa aplicação**

**Build, Release, Run: Segregar as etapas de build, configuração e deploy durante uma entrega de uma aplicação**

**Port binding: a aplicação deve disponibilizar seus serviços através de uma porta, sem depender de um servidor externo.**

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

**1. Camada de apresentação: Camada na qual o usuário realizará a interação com o sistema**

**2. Camada de Negócio: Camada onde é realizado o tratamento de dados e a Regra de negócio da aplicação**

**2. Camada de Persitência: Camada onde é realizada a interação com banco de dados, onde realizaremos as consultas e armazenamento dos dados.**


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta: SOA normalmente trabalha com serviços maiores e mais compartilhados, enquanto microserviços dividem a aplicação em serviços menores e mais independentes, cada um focado em uma responsabilidade específica.**


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta: Tem como objetivo centralizar e gerenciar as API's de uma aplicação. As prinicipais vantagens seria a Segurança dos dados, controle maior sobre as mesmas e a facilidade na realização de testes. A maior desvantagem, seria a complexidade maior na arquitetura do sistema.**


5. Qual a diferença entre uma Struct e uma Class?

**Resposta: Uma Struct não consegue ser herdada, diferente de uma Class. Além disso, a Class pode trabalhar com tipos por referência, enquanto a Struct trabalha com tipos por valor.**


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta: O .NET Foi desenvolvido para rodar exclusivamente no windows, já o .NET Core suporta diversos sistemas operacionais (como Linux, Mac, IOs, entre outros sistemas operacionais...)**


7. Quais as principais diferenças entre REST e GRPC?

**Resposta: REST geralmente usa HTTP e JSON/SOAP e é simples de consumir. gRPC usa HTTP/2 + Protocol Buffers, sendo mais rápido e comum para comunicação entre serviços.**


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta: O SPA em si realiza o mapeamento das rotas alterando os compontentes a serem visualizados conforme configurado, contudo, sem precisar recarregar a página inteira.**


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta: O Devops seria a junção das práticas de desenvolvimento de software com as operações de infraestrutura para se ter sucesso ao realizar a entrega de software**


10. Explique sobre um método agile.

**Resposta:O SCRUM é um framework Agil, que facilita o acompanhamento de todo o ciclo de desenvolvimento de um sistema, através de cerimonias e ritos de revisão e planejamento.**


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta: CI é a integração contínua para realização de testes e builds, CD refere-se a entrega contínua de uma aplicação para o deploy da mesma**

**Para esta estratégia, temos Azure DevOps, GitLabs, BitBucket entre outros...**


12. Qual a diferença entre Docker e Containers.

**Resposta: O Container é o processo que executa a aplicação alocada em uma imagem, O Docker seria a ferramenta para gerenciar e gerenciar estes Containers**


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta: Kubernetes é uma plataforma que facilita na orquestração de Multiplos containers. O OpenShift utiliza Kubernetes como base, mas oferece outras ferramentas adicionais para o gerenciamento.**


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta: APIs facilitam a integração entre o Front-End/Back-End e permitem carregar o conteúdo em uma página, sob demanda, sem precisar realizar uma requisição recarregar ela por inteiro, Mas como desvantagem, devemos tomar cuidado referente a sua disponibilidade e desempenho.**

**Devemos principalmente cuidar de segurança (autenticação) e aos tratamentos de erros**


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta: Aplicar métodos de autenticação como JWT, utilização correta dos verbos HTTP e a validação de dados que são requisitados a esta API**


16. Para que serve uma arquitetura de mensagerias?

**Resposta: Esta arquitetura, tem como objetivo, desaclopar microsserviços em suas comunicações, permitindo com que, quem realizou a requisição, não dependa da resposta imediata do consumidor para seguir com o fluxo normal.**


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta: SAGA é uma forma de controlar transações que envolvem vários microserviços. Cada serviço faz sua própria transação e, caso algo dê errado, são executadas ações de compensação.**


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta: GitOps é uma metodologia onde o Git é utilizado como fonte de verdade para as configurações da infraestrutura. No Kubernetes, ferramentas como o Argo CD podem acompanhar essas configurações e manter o cluster sincronizado com o que está definido no Git**

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

Diálogo Diário de Segurança

A solução visava automatizar o processo, no qual os registros eram feitos em papéis e transcritos para o Excel para a geração de KPIs.

Neste sistema, tínhamos a possibilidade de criar palestras para os DDS diários que ocorriam no terminal com os ajudantes gerais e operadores, para serem exibidas em uma lousa branca (de apresentação).

O fluxo era: o gestor cadastrava um DDS, inserindo um título, introdução e anexando um PDF ou PPTX para exibir o conteúdo desta DDS. Após isso, era gerado um link para apresentação. No final da apresentação, os QR Codes dos crachás dos participantes eram escaneados para registrar a presença no DDS, contendo dados como matrícula, cargo etc. Ao final dos registros de participação, era gerado um KPI informando todos os dados referentes à participação dos operadores, incluindo filtros avançados por data e cargo, média percentual e até previsão futura de participações.

O maior desafio neste projeto foi a normalização dos dados para a geração do KPI. Tendo em vista que não possuíamos um cadastro consistente de cargos e participantes terceiros, foram realizadas diversas tratativas e normalizações dos dados junto à área responsável, para que conseguíssemos alcançar uma geração de dados consistente e segura para os gestores.

Stacks Utilizadas:

- C# 8.0
- ASP.NET Core Web API
- Clean Architecture
- Princípios S.O.L.I.D.
- React.js
- Oracle
-Azure DevOps (para gerenciamento de tarefas e deploy via pipeline)
