# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

1. Codebase (Base de Código Única)
Uma aplicação deve ter um único repositório de código por app, versionado em controle de versão (ex: Git). Diversos deploys podem existir, mas sempre a partir da mesma base de código.

2. Dependencies (Dependências Declaradas)
As dependências devem ser explicitamente declaradas em arquivos de manifesto (ex: requirements.txt, package.json) e não depender de bibliotecas do sistema.

3. Config (Configurações em Variáveis de Ambiente)
Configurações específicas de ambiente (senhas, chaves, URLs) devem estar em variáveis de ambiente, não hardcoded no código.

4. Backing Services (Serviços de Apoio como Recursos)
Bancos de dados, filas, cache etc. devem ser tratados como recursos plugáveis, podendo ser trocados sem mudar o código.

5. Build, Release, Run (Separação de Etapas)
O ciclo da aplicação deve ter três fases:

 - Build: compilar/empacotar código.
 - Release: juntar código + config.
 - Run: executar a aplicação.

6. Processes (Execução como Processos Stateless)
A aplicação deve rodar como processos independentes e stateless. Dados persistentes devem ser armazenados em serviços externos (ex: banco de dados).

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Principais camadas no desenvolvimento de um software:

- Apresentação (Interface do Usuário)
Responsável pela interação com o usuário (ex.: telas web, apps móveis).
Foco em usabilidade e experiência.

- Aplicação (Lógica de Negócio)
Contém as regras de negócio e fluxos principais do sistema.
Faz a mediação entre a interface e os dados.

- Dados (Persistência/Armazenamento)
Responsável por acessar, armazenar e gerenciar os dados (ex.: bancos de dados, APIs).
Garante integridade e disponibilidade da informação.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

- SOA (Service-Oriented Architecture)
Baseada em serviços reutilizáveis que se comunicam via barramento (ESB – Enterprise Service Bus).
Voltada para integração de sistemas grandes e corporativos.
Tendência a serviços mais grandes e complexos.

- Microserviços
Baseada em serviços pequenos, independentes e autônomos.
Comunicação geralmente via APIs leves (HTTP/REST, gRPC, mensageria).
Voltada para agilidade, escalabilidade e deploy independente.

- Diferença principal:
SOA: foco em integração corporativa com serviços grandes.
Microserviços: foco em modularidade e escalabilidade com serviços pequenos e independentes.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

- Objetivo do API Management
Gerenciar o ciclo de vida das APIs em uma arquitetura distribuída, fornecendo segurança, monitoramento, controle de acesso, versionamento e escalabilidade.

 - Vantagens
Segurança: autenticação, autorização e proteção contra ataques.
Governança: padronização e controle centralizado de políticas.
Escalabilidade: suporte a alto volume de requisições.
Monitoramento: métricas e análise de uso em tempo real.

- Desvantagens
Complexidade: adiciona uma camada extra de gestão.
Custo: pode ser alto em soluções comerciais.
Latência: introduz atraso adicional nas chamadas de APIs.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

- Struct
Tipo de dado por valor (cópia ao atribuir).
Usada para dados simples e imutáveis.
Não suporta herança (na linguagens como C#).

- Class
Tipo de dado por referência (aponta para o objeto na memória).
Usada para modelar objetos complexos com comportamento.
Suporta herança, polimorfismo e encapsulamento.

- Diferença principal:
Struct = valor (leve, simples).
Class = referência (complexa, orientada a objetos).

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

- .NET Framework
Plataforma antiga e madura, lançada em 2002.
Funciona apenas no Windows.
Indicada para aplicações corporativas legadas (WinForms, WPF, ASP.NET clássico).

- .NET Core
Plataforma moderna, open source e multiplataforma (Windows, Linux, macOS).
Melhor suporte a performance, containers e microsserviços.
Base do .NET 5+, que unificou a plataforma.

- Grande diferença:
.NET Framework é restrito ao Windows e legado.
.NET Core é multiplataforma, moderno e base da evolução do .NET.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

- REST: comunicação via HTTP, formato JSON/XML, simples e amplamente usado.
- gRPC: comunicação via HTTP/2, binário, mais rápido e eficiente, suporta streaming.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

- SPA (Single Page Application) carrega uma única página HTML.
- Rotas são gerenciadas no front-end, alterando o estado da URL sem recarregar a página.
- Ferramentas: Angular Router.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

- DevOps integra desenvolvimento e operações, promovendo automação, CI/CD e entrega contínua.
- Objetivo: reduzir tempo de deploy e aumentar confiabilidade.

10. Explique sobre um método agile.

**Resposta:**

- Scrum: metodologia ágil baseada em sprints curtas, reuniões diárias e entregas incrementais.
- Foco: adaptação rápida e colaboração.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

- CI (Continuous Integration): integração contínua do código.
- CD (Continuous Delivery/Deployment): entrega contínua do software em produção.
- Ferramentas: Jenkins, GitHub Actions, GitLab CI, Azure DevOps.

12. Qual a diferença entre Docker e Containers.

**Resposta:**

- Containers: unidades leves que isolam aplicativos e dependências.
- Docker: plataforma que cria, gerencia e executa containers.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

- Kubernetes: orquestrador open-source de containers, gerencia deploy, scaling e networking.
- OpenShift: plataforma baseada em Kubernetes, com ferramentas adicionais, suporte a DevOps e segurança integrada.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

- Vantagens: integração entre sistemas, escalabilidade, reuso de serviços.
- Desvantagens: complexidade, manutenção, dependência de rede.
- Preocupações: segurança, versionamento, performance e monitoramento.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

- Autenticação e autorização (OAuth2, JWT).
- Criptografia (HTTPS/TLS).
- Rate limiting e monitoramento de acessos.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

- Facilita comunicação assíncrona entre serviços distribuídos.
- Garante desacoplamento, tolerância a falhas e escalabilidade.
- Exemplos: RabbitMQ, Kafka.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

- Coordena transações distribuídas através de passos locais com compensações em caso de falha.
- Permite manter consistência eventual sem bloqueio global.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

- GitOps usa repositórios Git como fonte única de verdade para configurações.
- Kubernetes aplica automaticamente mudanças quando o Git é atualizado, garantindo versionamento e auditabilidade.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

 - Desenvolvimento de aplicativo web para um portal da transparência.
 - Tecnologias: .NET Core, Angular, Dados.
 - Desafios: integração de APIs externas, escalabilidade e deploy.
 - Solução: implementação de microserviços.