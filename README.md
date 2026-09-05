# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

Codebase: um único repositório versionado por aplicação.
Dependencies: todas as dependências devem ser declaradas e isoladas.

Config: configurações específicas de ambiente ficam fora do código, normalmente em variáveis de ambiente.

Backing Services: serviços externos, como banco, Redis ou filas, devem ser tratados como recursos conectáveis.

Logs: a aplicação deve gerar logs como fluxo de eventos, deixando o ambiente responsável pelo armazenamento e processamento.

Processes: a aplicação deve rodar como processos stateless, sem depender de memória local para manter estado.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

De forma geral, temos apresentação, aplicação/serviços, domínio/regras de negócio e infraestrutura/persistência. Essa separação ajuda a manter responsabilidades bem definidas e facilita manutenção, testes e evolução do sistema.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

SOA normalmente trabalha com serviços mais abrangentes e um forte foco em integração e reutilização, podendo utilizar um ESB para comunicação. Microserviços buscam serviços menores, independentes, com responsabilidades bem definidas e possibilidade de deploy e escala individual. Na prática, microserviços priorizam bastante autonomia e desacoplamento.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

O API Management centraliza o gerenciamento e exposição das APIs, cuidando de autenticação, autorização, rate limit, monitoramento, versionamento e políticas de acesso.

Como vantagens, temos segurança centralizada, observabilidade, controle de tráfego e facilidade de governança. Como desvantagens, temos custo, aumento de complexidade e a possibilidade de virar um ponto de gargalo ou dependência central.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
A principal diferença é que struct é um tipo por valor e class é um tipo por referência. Structs são mais indicadas para objetos pequenos e normalmente imutáveis, enquanto classes são mais utilizadas para entidades e objetos com comportamento e ciclo de vida mais complexo.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
O .NET Framework é a plataforma tradicional da Microsoft, muito ligada ao Windows. O .NET Core surgiu como uma plataforma multiplataforma, mais leve e modular, com foco em performance e aplicações modernas. Hoje o .NET Core evoluiu para o .NET, que é a plataforma unificada atual.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST normalmente utiliza HTTP e JSON, sendo simples de consumir e bastante adequado para APIs públicas e integrações. gRPC utiliza HTTP/2 e Protocol Buffers, oferecendo comunicação binária mais eficiente e contratos fortemente tipados. Eu vejo gRPC sendo bastante interessante para comunicação interna entre microserviços quando performance é importante.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Em uma SPA, o navegador normalmente carrega uma única aplicação e o gerenciamento das rotas acontece no próprio frontend. Quando o usuário navega, o framework altera a URL e renderiza o componente correspondente sem precisar recarregar toda a página. Também é necessário configurar o servidor para redirecionar as rotas para o index.html

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Vejo DevOps como uma cultura e conjunto de práticas para aproximar desenvolvimento e operações, buscando automação, entregas rápidas e confiáveis e observabilidade. Já trabalhei com Docker, Kubernetes, CI/CD, Git, AWS, Linux, monitoramento e logs. Também considero infraestrutura como código e automação importantes nesse processo.

10. Explique sobre um método agile.

**Resposta:**
Um exemplo é o Scrum. O trabalho é dividido em Sprints, normalmente de duração fixa, com planejamento, acompanhamento diário, review e retrospectiva. A ideia é entregar incrementos de valor continuamente, receber feedback rápido e adaptar o planejamento conforme necessário.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI é a integração contínua, onde alterações são integradas e validadas automaticamente através de testes, builds e análises. CD pode ser Continuous Delivery ou Continuous Deployment, automatizando a disponibilização das aplicações nos ambientes. Já trabalhei com pipelines, GitLab, Bitbucket, Azure, Docker e AWS nesse contexto.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Container é o conceito de executar uma aplicação isolada junto com suas dependências. Docker é uma das principais ferramentas utilizadas para criar, executar e gerenciar esses containers. Ou seja, container é o conceito e Docker é uma tecnologia utilizada para trabalhar com ele.
13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é uma plataforma open source para orquestração de containers. OpenShift é uma plataforma da Red Hat construída sobre Kubernetes, adicionando recursos de segurança, gerenciamento, developer experience e ferramentas integradas. Eu vejo o OpenShift como uma distribuição/plataforma empresarial em cima do Kubernetes.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
As principais vantagens são integração, reutilização, desacoplamento entre sistemas e possibilidade de escalar serviços independentemente.

As desvantagens são aumento de complexidade, latência de rede, necessidade de segurança, versionamento, observabilidade e tratamento de falhas.

Ao projetar uma API, eu me preocupo principalmente com contrato, autenticação, autorização, versionamento, idempotência, tratamento de erros, performance, rate limiting e observabilidade

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Utilizando HTTPS, autenticação e autorização adequadas, como OAuth2/JWT, validação e sanitização dos dados de entrada, rate limiting, controle de permissões e proteção contra vulnerabilidades como SQL Injection e OWASP Top 10. Também considero importante manter logs, monitoramento, gerenciamento seguro de secrets e realizar testes de segurança.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Serve para permitir comunicação assíncrona entre sistemas e serviços, reduzindo o acoplamento. Também ajuda em escalabilidade, processamento em background e resiliência. Já trabalhei com conceitos de filas e eventos utilizando tecnologias como AWS SQS e SNS.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
SAGA é uma estratégia para controlar transações distribuídas entre microserviços. Em vez de uma única transação envolvendo vários serviços, cada serviço executa sua própria transação e, caso algo falhe, são executadas ações de compensação. Pode ser implementada de forma orquestrada ou baseada em eventos.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Esse aqui eu não conheço. Tive que pesquisar.

GitOps é uma abordagem onde o Git funciona como fonte de verdade para o estado desejado da infraestrutura e das aplicações. No Kubernetes, alterações de manifests ou configurações são feitas no Git e uma ferramenta como Argo CD ou Flux sincroniza esse estado com o cluster. Isso traz rastreabilidade, versionamento, auditoria e facilita rollback.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Um caso que considero interessante aconteceu na Methodical Group. Tivemos um problema em uma tela que apresentava uma espécie de tela branca para o usuário. Analisando os logs do PHP, identifiquei que a aplicação estava tentando carregar uma quantidade muito grande de dados de uma vez, causando um problema de performance.

A solução foi alterar o fluxo de busca. Implementamos um campo de pesquisa que só começava a consultar após o usuário informar pelo menos três caracteres e limitamos o retorno inicial para 30 resultados. O frontend utilizava esses resultados para apresentar as sugestões.

Trabalhei diretamente na análise do problema, investigação dos logs, alteração da API e implementação da solução. O principal desafio foi resolver o problema de performance sem prejudicar a experiência do usuário. A solução reduziu significativamente a quantidade de dados processados e tornou a tela muito mais responsiva.