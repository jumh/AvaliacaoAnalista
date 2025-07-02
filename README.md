# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

Codebase: Uma base de código versionada, com múltiplos deploys. Todos os ambientes compartilham o mesmo repositório.

Dependencies: Todas as dependências devem ser explicitamente declaradas e isoladas do sistema.

Config: As configurações da aplicação devem ser armazenadas em variáveis de ambiente, e nunca no código.

Backing Services: Serviços externos (como banco de dados, cache) devem ser tratados como recursos substituíveis.

Build, Release, Run: Três estágios distintos — build (compilação), release (configuração) e run (execução).

Processes: A aplicação deve ser stateless, executando como um ou mais processos sem armazenar estado local.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Apresentação (UI): Interface com o usuário.

Aplicação (ou Service): Contém a lógica de orquestração da aplicação.

Domínio (ou Regras de Negócio): Contém as regras e entidades do sistema.

Persistência (ou Repositório): Responsável pelo acesso a dados (banco de dados, arquivos, etc.).

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

SOA (Service-Oriented Architecture): Baseada em serviços reutilizáveis e integrados via barramento (ESB), foco na interoperabilidade.

Microserviços: Divide o sistema em serviços pequenos, independentes, que se comunicam geralmente via HTTP ou mensageria. Possui maior granularidade e autonomia entre os serviços.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Objetivo: Gerenciar, proteger, monitorar e versionar APIs.

Vantagens: Segurança (autenticação/autorização), rate limiting, logging, versionamento, documentação.

Desvantagens: Pode adicionar complexidade e custos ao ambiente.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct: Tipo por valor, armazenado na stack, não suporta herança.

Class: Tipo por referência, armazenado no heap, suporta herança e polimorfismo.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET Framework: Focado em Windows, legado, suporte limitado a plataformas.

.NET Core: Multiplataforma (Windows, Linux, macOS), open-source, melhor performance e modularidade.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST: Baseado em HTTP/1.1, usa JSON, mais fácil de integrar com navegadores.

gRPC: Usa HTTP/2, baseado em Protobuf (binário), mais eficiente e rápido, ideal para comunicação entre microsserviços.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Em uma SPA (Single Page Application), o roteamento é feito no lado do cliente, geralmente usando bibliotecas como React Router ou Vue Router, sem recarregar a página. As URLs são gerenciadas com o histórico do navegador, e o conteúdo muda dinamicamente via JavaScript.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é uma cultura e prática que une desenvolvimento (Dev) e operações (Ops), com foco em automação, integração contínua, entrega contínua, monitoramento e colaboração, com o objetivo de entregar software com mais qualidade e rapidez.


10. Explique sobre um método agile.

**Resposta:**
Scrum, por exemplo, é um método ágil baseado em ciclos chamados sprints (geralmente de 1 a 4 semanas), com reuniões diárias (daily scrum), planejamento de sprint, retrospectiva e revisão. Foca em entregas incrementais e melhoria contínua.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Integração Contínua): Automatiza testes e builds a cada commit (ex: GitHub Actions, Azure DevOps, Jenkins).

CD (Entrega/Implantação Contínua): Automatiza deploy em ambientes após validação. Ferramentas comuns: GitLab CI/CD, ArgoCD, FluxCD.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker: Plataforma que facilita a criação, execução e gerenciamento de containers.

Container: Unidade leve e isolada que empacota a aplicação com suas dependências. Docker é uma das implementações de containers.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes: Orquestrador de containers open-source.

Openshift: Plataforma da Red Hat que usa Kubernetes e adiciona ferramentas de segurança, gerenciamento e interface gráfica. Mais opinado e corporativo.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Vantagens: Reutilização, integração entre sistemas, desacoplamento.

Desvantagens: Segurança, versionamento, latência e dependência de rede.

Preocupações: Autenticação/autorização, documentação, limites de uso (rate limiting), testes e monitoramento.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Autenticação via OAuth2/JWT.

Criptografia (HTTPS).

Rate limiting.

Validação de entrada.

Logs e monitoramento.

Versionamento e uso de API Gateway.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Permite comunicação assíncrona entre serviços usando filas ou tópicos (ex: RabbitMQ, Kafka). Melhora desacoplamento, escalabilidade e tolerância a falhas.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Saga é um padrão de orquestração/distribuição de transações em microsserviços, onde cada serviço realiza uma ação local e, em caso de falha, aciona uma ação compensatória para desfazer as etapas anteriores, mantendo a consistência eventual.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma abordagem onde a infraestrutura e aplicações são declaradas em arquivos versionados em Git. A partir desse repositório, ferramentas como ArgoCD ou Flux sincronizam e aplicam automaticamente as configurações no Kubernetes, garantindo rastreabilidade, rollback e automação.


19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Em uma das principais migrações em que atuei, na última empresa em que trabalhei, realizamos a migração de uma infraestrutura hospedada no Digital Ocean para a AWS. A transição foi feita de forma gradual, pois o sistema era muito grande, com diversos gargalos de processamento e problemas de performance, o que resultava em uma experiência ruim para os usuários e um custo elevado com a infraestrutura em nuvem.

Na AWS, utilizamos o serviço Elastic Beanstalk para hospedar as APIs, o que nos proporcionou escalabilidade automática e balanceamento de carga eficiente. Também adotamos o AWS EventBridge para orquestrar eventos que acionavam microserviços desenvolvidos utilizando AWS Lambda.

Além da migração de infraestrutura, realizamos melhorias significativas no código, o que impactou diretamente na performance e nos custos da aplicação. Como resultado final, conseguimos reduzir mais da metade dos gastos com cloud, ao mesmo tempo em que melhoramos a estabilidade e a experiência do usuário.