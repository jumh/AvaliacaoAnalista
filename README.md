# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
1) Codebase: uma base de código por aplicação, versionada em repositório, podendo ter múltiplos deploys (dev, hml, prod).
2) Dependencies: dependências declaradas explicitamente (ex.: arquivo de projeto), sem depender de bibliotecas “globais” da máquina.
3) Config: configurações por ambiente ficam fora do código (variáveis de ambiente, secrets manager).
4) Backing Services: banco, fila, cache e outros serviços externos são recursos anexados e trocáveis sem alterar regra de negócio.
5) Build, Release, Run: separar etapas de build, release e execução para dar rastreabilidade e reduzir erro manual.
6) Logs: tratar logs como fluxo de eventos (stdout/stderr), centralizando em ferramenta de observabilidade.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
De forma prática, costumo dividir em: 

- Presentation/WebApi: (UI/API); 
- Application: (orquestra casos de uso);
- Domain: (regras de negócio); 
- Infraestrutura: (banco, fila, integrações);
- Dados: (repositórios, mapeamentos, queries). 

Dependendo da arquitetura, algumas dessas camadas ficam em projetos separados.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA é uma arquitetura orientada a serviços, normalmente com serviços maiores, compartilhamento maior de recursos e frequentemente um ESB centralizando integração. Microserviços quebram o sistema em serviços menores, autônomos, com deploy independente e responsabilidade de negócio bem delimitada. Em resumo: microserviços podem ser vistos como uma evolução mais granular e desacoplada de ideias de SOA.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O API Management centraliza governança das APIs: autenticação, rate limit, versionamento, analytics, documentação e políticas.

Vantagens: segurança padronizada, visibilidade de consumo, controle de tráfego, onboarding mais rápido de consumidores.

Desvantagens: custo de plataforma, aumento de complexidade operacional e possível ponto adicional de latência.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Em C#, `struct` é tipo por valor e `class` é tipo por referência. Struct tende a ser melhor para objetos pequenos, imutáveis e de vida curta (ex.: coordenada, valor monetário simples), pois evita alocação no heap em vários cenários. Class é mais indicada para objetos com comportamento mais complexo, herança e ciclo de vida mais longo.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
Hoje o cenário evoluiu para `.NET` (5+), que unificou o ecossistema moderno e multiplataforma. O `.NET Framework` é o legado mais antigo e focado em Windows. O `.NET Core` foi o passo inicial dessa modernização (cross-platform, performance, cloud), e depois virou a base do `.NET` atual.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST normalmente usa HTTP + JSON, é simples de consumir e muito bom para integração pública. gRPC usa HTTP/2 + Protobuf, com payload menor e comunicação mais performática, inclusive streaming nativo. Para cenários internos entre serviços, gRPC costuma ter vantagem em performance. Para ecossistema aberto e compatibilidade ampla, REST costuma ser mais simples.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Numa SPA, o roteamento é controlado no cliente (browser), sem recarregar a página inteira a cada navegação. O router mapeia URL para componentes/telas, permite rotas protegidas (auth), rotas com parâmetros e lazy loading. No backend, normalmente configuramos fallback para o `index` para rotas front funcionarem direto via URL.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é cultura + prática para aproximar desenvolvimento e operação, com foco em entrega contínua, automação e confiabilidade. No dia a dia envolve pipeline, observabilidade, infraestrutura como código, testes automatizados e feedback rápido. O objetivo é entregar valor com frequência, mantendo estabilidade e segurança.


10. Explique sobre um método agile.

**Resposta:**
Um método que uso bastante é **Scrum**: trabalho em ciclos curtos (sprints), com planejamento, execução, review e retrospectiva. Isso ajuda a quebrar entregas grandes em incrementos menores, com validação frequente com o negócio. Na prática, melhora previsibilidade e facilita ajuste de prioridade.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Integração Contínua) automatiza build, testes e análise de código a cada commit/PR. CD (Entrega/Deploy Contínuo) automatiza publicação em ambientes com segurança e rastreabilidade.

Ferramentas comuns: GitHub Actions, Azure DevOps Pipelines, Docker, Kubernetes, além de monitoramento com Grafana/Prometheus e logs com ELK.


12. Qual a diferença entre Docker e Containers.

**Resposta:**
Container é o conceito: empacotar aplicação + dependências de forma isolada e portátil. Docker é uma das plataformas/ferramentas mais usadas para criar, executar e distribuir containers. Ou seja, Docker não é sinônimo do conceito, é uma implementação muito popular dele.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é o orquestrador open source de containers. OpenShift é uma plataforma baseada em Kubernetes com recursos adicionais de segurança, governança, CI/CD e experiência de desenvolvedor já integrados. Em geral, OpenShift entrega mais “pronto”, enquanto Kubernetes puro exige mais montagem e padronização por parte do time.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Vantagens: integração entre sistemas, escalabilidade de times, reaproveitamento de serviços e evolução independente de clientes.

Desvantagens: aumento de complexidade distribuída (latência, versionamento, observabilidade, falhas de rede).

Cuidados na escolha: definir contrato claro, estratégia de versionamento, autenticação/autorização, limites de uso, monitoramento e políticas de resiliência (retry, timeout, circuit breaker).


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Aplicando segurança em camadas: HTTPS obrigatório, autenticação forte (OAuth2/JWT), autorização por escopo/perfil, validação de entrada e rate limit. Além disso, gestão de segredos (cofre), rotação de chaves, logs de auditoria e testes de segurança (SAST/DAST). Também é importante seguir princípio do menor privilégio e manter dependências atualizadas.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Serve para desacoplar sistemas por comunicação assíncrona, aumentando resiliência e escalabilidade. Com fila/tópico, produtores e consumidores evoluem de forma independente e absorvem picos de carga melhor. Também ajuda em cenários de processamento em background e integração entre domínios diferentes.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Saga é um padrão para manter consistência entre múltiplos serviços sem transação distribuída tradicional. Uma operação de negócio é quebrada em etapas locais, e cada etapa tem ação de compensação caso algo falhe. Pode ser orquestrada (um coordenador decide o fluxo) ou coreografada (serviços reagem a eventos).


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é usar o Git como fonte única de verdade para estado desejado do cluster. Alterações de infraestrutura e deploy são feitas via PR, com revisão, histórico e auditoria. Uma ferramenta no cluster (ex.: Argo CD/Flux) reconcilia continuamente o estado real com o que está versionado no repositório.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Um case relevante que atuei foi na Movecta, em um projeto de integração entre dois sistemas TOS, responsáveis pela gestão de pátio logístico.

O problema era que os sistemas não se comunicavam diretamente, pois tinham formatos de dados diferentes, e precisávamos garantir a troca de informações de eventos operacionais, como entrada e saída de caminhões (gate-in/gate-out).

A solução foi desenvolver um integrador backend baseado em eventos, utilizando RabbitMQ como broker de mensageria. O sistema recebia eventos do sistema A, armazenava em filas específicas e workers consumiam esses eventos, aplicavam as transformações necessárias e enviavam para o sistema B no formato esperado.

Tecnologias utilizadas: .NET para desenvolvimento dos workers, RabbitMQ para mensageria e banco de dados relacional para controle e idempotência. A arquitetura era orientada a eventos, com processamento assíncrono.

Os principais desafios foram perda de eventos em caso de falha (resolvido com DLQ e estratégia de retry), duplicidade de eventos (resolvido com idempotência no banco), alto volume de processamento (cerca de 8 mil eventos/dia, resolvido com desacoplamento e controle de consumo via mensageria) e diferença de contratos entre os sistemas (resolvido com uma camada de transformação).

Como resultado, conseguimos garantir uma integração estável e resiliente entre os sistemas, evitando perda de dados e suportando picos de volume. A solução também melhorou a escalabilidade e abriu espaço para evolução futura para microserviços.
