# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

O Twelve-Factor App traz princípios importantes para desenvolvimento de aplicações modernas. Vou destacar 6 que considero essenciais:

**Codebase** - A ideia aqui é simples: um repositório, múltiplos deploys. Você tem um único código-fonte no Git, mas pode ter várias implantações dele rodando em dev, staging e produção. Isso facilita muito o controle e evita aquela bagunça de ter códigos diferentes para cada ambiente.

**Dependencies** - Tudo que sua aplicação precisa deve estar explicitamente declarado. Nada de contar com aquela lib que "já vem instalada no servidor". Use NuGet, npm, ou o gerenciador da sua stack e deixe tudo documentado. Isso evita aquele clássico "mas na minha máquina funciona".

**Config** - Nunca coloque credenciais ou configurações específicas de ambiente no código. Usa variáveis de ambiente para isso. A string de conexão do banco de produção não tem nada que estar no seu appsettings.json commitado no Git. Cada ambiente deve ter suas próprias configs.

**Backing Services** - Bancos de dados, filas, caches... trate todos como recursos que você anexa à aplicação. A beleza disso é que você pode trocar um PostgreSQL local por um RDS da AWS só mudando a configuração, sem mexer no código.

**Processes** - Sua aplicação deve ser stateless. Se você precisa guardar alguma coisa entre requisições, usa um banco ou cache, não a memória do processo. Isso permite escalar horizontalmente sem dor de cabeça.

**Concurrency** - Quando precisar de mais poder de processamento, adicione mais instâncias da aplicação ao invés de só aumentar CPU/RAM de uma máquina. É o famoso scale out ao invés de scale up.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Normalmente trabalhamos com uma arquitetura em camadas para organizar melhor o código. As principais são:

**Apresentação** - É onde o usuário interage com o sistema. Tudo que é visual, botões, formulários, telas. No mundo web seria os controllers, views, componentes React/Angular/Vue. É a "cara" da aplicação.

**Aplicação** - Aqui fica a orquestração dos casos de uso. É tipo o maestro que coordena tudo. Quando o usuário clica em "finalizar pedido", essa camada pega os dados, chama as regras de negócio, fala com o banco, etc.

**Domínio/Negócio** - O coração do sistema. Aqui ficam as regras de negócio puras, as entidades, validações. É o que faz sua aplicação ser única. Essa camada não deve depender de frameworks ou tecnologias específicas.

**Dados** - Tudo relacionado a persistência. Repositórios, Entity Framework, queries SQL, acesso ao banco. É quem sabe como salvar e recuperar informações.

**Infraestrutura** - Os serviços de suporte que várias camadas usam: logs, autenticação, envio de email, cache, integração com APIs externas. São as preocupações transversais do sistema.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Embora pareçam similares à primeira vista, há diferenças importantes entre SOA e microserviços.

SOA é uma abordagem mais antiga, onde você tem serviços reutilizáveis que se comunicam através de um barramento (ESB). É tipo ter um grande centralizador por onde tudo passa. Os serviços costumam ser maiores e muitas vezes compartilham o mesmo banco de dados. A comunicação é geralmente via SOAP/XML, mais pesada e formal. Tem uma governança centralizada e os serviços compartilham infraestrutura.

Já microserviços leva a ideia de separação muito mais longe. Cada serviço é pequeno, focado em fazer uma coisa bem feita, e tem seu próprio banco de dados. Isso mesmo - nada de compartilhar banco! A comunicação é mais leve, usando REST, gRPC ou mensageria. Cada time pode escolher a tecnologia que faz mais sentido pro seu serviço - um pode ser .NET, outro Node, outro Python. Deploy é independente, então você atualiza um serviço sem afetar os outros.

No fim das contas, microserviços são mais descentralizados e autônomos, enquanto SOA é mais centralizado e compartilhado. Microserviços trazem mais flexibilidade, mas também mais complexidade operacional.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

API Management é basicamente um gateway centralizado que fica entre os consumidores e suas APIs, gerenciando e controlando tudo que passa por ali.

O grande objetivo é ter um ponto central para cuidar de segurança (autenticação, autorização, rate limiting), monitoramento (quem tá chamando o quê, quantas vezes), versionamento, documentação... enfim, tudo que envolve governança de APIs. Ele também pode fazer transformações nas requisições, cache, roteamento inteligente e até facilitar a monetização se você cobra pelo uso das APIs.

As vantagens são claras: você centraliza toda a segurança, tem visibilidade do que tá acontecendo, pode implementar políticas de forma consistente e facilita a vida de quem consome suas APIs.

Mas tem o outro lado. Se você não arquitetar bem, ele vira um ponto único de falha - se cair, todas as APIs morrem juntas. Adiciona latência na comunicação, afinal é mais um hop na rede. A configuração pode ser complexa e tem custo, seja de infra ou licenciamento de ferramentas como Apigee. Se mal dimensionado, vira um gargalo de performance.

Ferramentas populares são Kong, Apigee, AWS API Gateway e Azure API Management. Cada uma com seus prós e contras.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Essa é uma dúvida clássica em C#/.NET. A diferença principal está em como são armazenadas e passadas na memória.

Struct é um tipo de valor. Ela fica na stack e quando você passa uma struct como parâmetro, está passando uma cópia dela. Structs não suportam herança (só implementam interfaces) e são melhores para dados pequenos e imutáveis. Pensa em tipos como int, DateTime, Point - todos são structs. São leves e rápidos.

Class é tipo de referência, fica na heap e é gerenciada pelo Garbage Collector. Quando você passa uma classe como parâmetro, está passando a referência (tipo um ponteiro). Classes suportam herança completa, podem ter construtores, destrutores, e são indicadas para objetos mais complexos.

A regra de ouro é: use struct para objetos pequenos (menos de 16 bytes), imutáveis, que representam logicamente um único valor - tipo uma coordenada (X, Y) ou uma cor (R, G, B). Para o resto, use class.

Uma pegadinha comum é que structs não podem ser null (a não ser que sejam nullable), enquanto classes podem. E quando você modifica uma struct que foi copiada, a original não muda - o que pode confundir no início.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

Essa é uma questão que mudou bastante nos últimos anos. O .NET Framework foi lançado em 2002 e é aquele framework clássico da Microsoft, mas que só roda em Windows. Ele é mais monolítico, acoplado ao sistema operacional, e suporta tecnologias legadas como WinForms, WPF e ASP.NET Web Forms. A versão 4.8 foi a última - hoje só recebe manutenção.

Já o .NET Core foi um "restart" lançado em 2016. A Microsoft reescreveu tudo do zero pensando em ser cross-platform (roda em Windows, Linux, macOS), modular, open-source e com performance otimizada. É muito mais enxuto, perfeito para containers e aplicações cloud-native. Você pode fazer deploy self-contained (leva o runtime junto) ou framework-dependent.

Uma coisa importante: a partir do .NET 5, a Microsoft unificou tudo. Não existe mais ".NET Core" como nome. Agora é só ".NET" mesmo (6, 7, 8, 9...). É a evolução do .NET Core, que absorveu o melhor do .NET Framework.

Então se você vai começar um projeto novo hoje, usa .NET 8 (ou 9). O .NET Framework é legado, mas ainda vai estar por aí durante anos em sistemas antigos.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST e gRPC são duas abordagens bem diferentes para comunicação entre serviços.

REST é o que todo mundo conhece - baseado em HTTP, usa JSON (ou XML), tem aqueles verbos clássicos GET, POST, PUT, DELETE. É super fácil de debugar, você consegue até testar no browser ou Postman. Por ser texto, o payload é maior e tem mais overhead, mas a simplicidade compensa. É perfeito para APIs públicas e comunicação com clientes externos.

gRPC é mais parrudo. Usa HTTP/2 obrigatoriamente e Protocol Buffers (binário, bem compacto). É fortemente tipado - você define contratos .proto e gera código a partir deles. A performance é muito melhor que REST porque o payload é binário e menor. O legal é que suporta streaming bidirecional, então dá pra fazer coisas que REST não consegue facilmente. Por outro lado, debugar é mais chato, precisa de ferramentas específicas.

Na prática, REST é melhor para APIs públicas, integrações externas, quando você quer simplicidade. gRPC brilha na comunicação interna entre microserviços, onde performance importa e você controla cliente e servidor. Muita gente usa REST pro mundo externo e gRPC pro mundo interno.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Em uma SPA (Single Page Application), todo o roteamento acontece no lado do cliente, sem recarregar a página. É bem diferente das aplicações tradicionais onde cada rota é uma requisição ao servidor.

O segredo está na History API do browser - métodos como `pushState()` e `replaceState()` que permitem mudar a URL sem recarregar a página. Daí entra o router (React Router, Vue Router, Angular Router) que fica observando essas mudanças e renderiza o componente certo pra cada rota.

Você define um mapeamento tipo: /home mostra o HomeComponent, /users/:id mostra os detalhes do usuário, etc. Quando o usuário clica num link ou você navega via código, o router troca os componentes na tela instantaneamente. Dá pra fazer lazy loading também - carregar os componentes sob demanda pra não deixar o bundle inicial pesado.

Uma coisa importante: você pode ter guards ou middleware nas rotas, tipo verificar se o usuário tá autenticado antes de deixar ele acessar certas páginas.

E tem um detalhe crucial no servidor: ele precisa redirecionar todas as rotas para o index.html (exceto APIs), porque quando o usuário der refresh ou acessar uma URL diretamente, o servidor precisa devolver a SPA pra que o router client-side assuma.

O resultado é aquela experiência fluida, sem page refresh, que deixa a aplicação com cara de app nativo.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é mais uma cultura do que uma ferramenta ou cargo. A ideia é quebrar aquele muro histórico entre desenvolvimento e operações, onde os devs jogavam código por cima do muro e o pessoal de ops que se virasse pra colocar em produção.

A essência do DevOps é colaboração, automação e medição contínua. As equipes trabalham juntas desde o início, com responsabilidade compartilhada pelo ciclo de vida completo da aplicação. Todo mundo se preocupa tanto com features novas quanto com estabilidade e performance em produção.

Na prática, isso se traduz em várias coisas: CI/CD pra automatizar build, testes e deploy; Infrastructure as Code com Terraform ou Ansible pra versionar a infra; containers com Docker e Kubernetes pra ambientes consistentes; monitoramento robusto com Prometheus, Grafana, ELK Stack pra observabilidade.

O resultado é deploy mais frequente e confiável, menos tempo pra recuperar de problemas, mais qualidade no software e melhor comunicação entre as equipes. Quando algo quebra em produção, todo mundo corre junto pra resolver, não fica naquela de "culpa de quem?".

No fim, DevOps é muito mais sobre pessoas e processos do que sobre ferramentas. As ferramentas ajudam, mas sem a cultura certa não adianta nada.


10. Explique sobre um método agile.

**Resposta:**

Vou falar sobre Scrum que é o método ágil mais usado no mercado. Ele divide o trabalho em ciclos curtos chamados Sprints, geralmente de 2 semanas.

Tem 3 papéis principais: o Product Owner, que define o que precisa ser feito e prioriza; o Scrum Master, que facilita o processo e remove impedimentos; e o Development Team, que é auto-organizado e faz o trabalho acontecer.

O Product Owner mantém um backlog com todas as funcionalidades priorizadas. Na Sprint Planning, o time escolhe o que vai fazer na sprint. Todo dia tem a Daily (stand-up) de 15 minutos pra todo mundo alinhar o que fez, o que vai fazer e se tem algum bloqueio.

No final da sprint, tem a Sprint Review onde mostramos o que foi feito pros stakeholders, e depois a Retrospectiva onde o time reflete sobre o que pode melhorar no processo.

O legal do Scrum é que você entrega valor rapidamente e de forma iterativa. Se o cliente mudar de ideia ou aparecer algo mais importante, dá pra adaptar na próxima sprint. Tem transparência total do que tá sendo feito, e o time tá sempre inspecionando e melhorando o processo.

Os valores do Scrum são: Comprometimento, Coragem, Foco, Abertura e Respeito. Sem esses valores, vira só burocracia.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI/CD é o coração de qualquer pipeline moderno de desenvolvimento.

CI (Continuous Integration) é a prática de integrar código no repositório principal várias vezes ao dia. Cada commit dispara um pipeline automatizado que builda o código, roda os testes, faz análise de código. Se algo quebrou, você fica sabendo em minutos, não em dias. Isso evita aquela situação clássica de "funcionava na minha máquina" e integration hell.

CD tem duas interpretações: Continuous Delivery e Continuous Deployment. Delivery significa que seu código tá sempre pronto pra ir pra produção, mas você decide quando fazer o deploy (aprovação manual). Deployment vai além - se passou nos testes, vai pra produção automaticamente. É mais agressivo, mas quando bem feito, permite múltiplos deploys por dia.

As ferramentas mais comuns no dia a dia são: Jenkins (o veterano, open-source e super customizável), GitHub Actions (muito prático se você já usa GitHub), GitLab CI/CD (integrado ao GitLab), Azure DevOps (excelente pra stack .NET), CircleCI, TeamCity e Travis CI.

O benefício é óbvio: você pega bugs mais cedo, faz releases com mais confiança e frequência, tem feedback imediato do que quebrou. No final do dia, você dorme melhor sabendo que tem uma rede de segurança automatizada.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Muita gente confunde, mas containers e Docker não são a mesma coisa.

Containers são o conceito - uma tecnologia de isolamento de processos que existe há décadas. É tipo uma caixa onde você coloca sua aplicação com todas as dependências, isolada do resto do sistema, mas compartilhando o kernel do SO. É mais leve que uma VM porque não precisa de um sistema operacional completo pra cada instância. As tecnologias por trás (cgroups, namespaces no Linux) são antigas.

Docker é uma plataforma específica pra trabalhar com containers. Foi o Docker que popularizou e simplificou o uso de containers, criando uma interface amigável com Dockerfile, docker build, docker run. Além do runtime, o Docker trouxe todo um ecossistema: Docker Hub pra compartilhar imagens, Docker Compose pra orquestrar múltiplos containers, etc.

É tipo a diferença entre "carro" e "Ford". Container é o conceito, Docker é uma implementação. Você pode usar outros runtimes de container como Podman, containerd, CRI-O. Mas Docker virou quase sinônimo de container porque foi quem popularizou.

Hoje em dia, muita gente usa Kubernetes com containerd ao invés do Docker runtime, mas continua usando imagens Docker. O ecossistema todo se beneficiou do que o Docker construiu.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é a plataforma open-source de orquestração de containers criada pelo Google e mantida pela CNCF. É tipo o "vanilla" - você tem o core, mas precisa configurar e adicionar muita coisa pra deixar production-ready. Segurança, monitoramento, CI/CD, registry... tudo você monta do zero. É super flexível e customizável, mas a curva de aprendizado é íngreme. E é gratuito, só paga a infra.

OpenShift é o Kubernetes turbinado pela Red Hat/IBM. Pega o K8s e adiciona um monte de coisa enterprise out-of-the-box: segurança reforçada por padrão, um console web muito melhor, CI/CD integrado, Source-to-Image pra buildar apps direto do código, registry próprio. É tipo pegar o Kubernetes e deixar pronto pra produção corporativa. Mas claro, você paga por isso - tem licenciamento comercial, mas ganha suporte da Red Hat.

Uma analogia boa: Kubernetes é como o kernel Linux, OpenShift é como Red Hat Enterprise Linux (RHEL). Um é a base, o outro é a distribuição enterprise com tudo que uma empresa grande precisa.

Se você tem uma equipe experiente e quer flexibilidade máxima, vai de Kubernetes puro. Se quer algo mais gerenciado, com suporte e ferramentas prontas, OpenShift faz sentido. Hoje também tem outras opções managed como EKS, GKE, AKS que ficam no meio termo.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

APIs trazem muitas vantagens. O principal é o desacoplamento - frontend e backend podem evoluir independentemente. A mesma API serve web, mobile, IoT, o que quiser. Você pode escalar cada parte separadamente, facilita integração com terceiros, e permite que equipes trabalhem em paralelo sem pisar no pé uma da outra.

Mas não é só flores. Adiciona complexidade - agora você tem múltiplos pontos de falha. Tem latência de rede entre as chamadas, overhead de comunicação. Versionamento vira uma dor de cabeça se não for bem planejado desde o início. E quando algo quebra, debugar é mais complicado porque tá tudo distribuído. Sem contar o custo extra de infraestrutura e monitoramento.

As preocupações que você precisa ter na cabeça desde o dia zero são várias. Segurança é crítica - autenticação (OAuth, JWT), autorização, rate limiting, proteção contra ataques. Versionamento também, define logo se vai ser na URL, header ou query parameter e mantém consistência.

Performance é outro ponto: implementa cache, paginação, compressão. Documentação com Swagger/OpenAPI é obrigatório, ninguém aguenta API sem doc. Garante compatibilidade backward nos contratos pra não quebrar clientes antigos.

Monitoramento robusto (logs, métricas, distributed tracing) e resiliência (circuit breaker, retry policies, timeouts) salvam a sua vida em produção. E por último, governança - define padrões e faz todo mundo seguir, senão vira bagunça.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Segurança em APIs é camada sobre camada, não tem bala de prata.

Primeiro, autenticação e autorização robustas. OAuth 2.0/OpenID Connect pro padrão moderno, JWT pra tokens stateless, API Keys pra identificar aplicações. Em ambientes críticos, dá pra usar mTLS com certificados bidirecionais. Implementa RBAC ou ABAC pra controle de acesso granular - princípio do menor privilégio sempre.

HTTPS/TLS é obrigatório, sem exceção. Criptografa dados em trânsito e em repouso também. Nunca exponha dados sensíveis em logs ou mensagens de erro. É incrível quantas APIs vazam informação por descuido.

Proteção contra ataques é fundamental. Rate limiting pra prevenir DDoS e abuso, validação e sanitização de todas as entradas (nunca confie no usuário), prepared statements ou ORM pra evitar SQL injection. Configura CORS corretamente, headers de segurança (CSP, X-Frame-Options, etc).

Monitoramento e auditoria constante. Loga tudo relevante, detecta anomalias, alerta sobre tentativas suspeitas. Se alguém tá tentando quebrar sua API, você precisa saber.

E as boas práticas: estuda o OWASP API Security Top 10, faz testes de penetração regularmente, escaneia dependências pra vulnerabilidades conhecidas. Um API Gateway bem configurado centraliza muita coisa e facilita a vida.

Segurança não é projeto, é processo contínuo.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Mensageria é essencial quando você precisa que serviços conversem de forma assíncrona e desacoplada. Ao invés de uma chamada direta síncrona (tipo REST), você joga uma mensagem numa fila e segue a vida. O consumidor processa quando pode.

O grande valor é o desacoplamento. O produtor não precisa saber quem vai consumir a mensagem, nem se preocupar se o consumidor tá online. A mensagem fica persistida na fila até alguém processar. Se um serviço cair, as mensagens ficam lá esperando, nada se perde.

Ajuda muito com picos de carga. Imagina uma Black Friday - milhões de pedidos chegando. Ao invés de sobrecarregar o sistema de processamento, você enfileira tudo e vai processando conforme a capacidade. Dá pra adicionar mais consumidores pra processar em paralelo.

Casos de uso clássicos: processamento de pedidos de e-commerce, envio de emails/notificações em massa, event-driven architecture, integração entre microserviços, pipelines de dados, jobs assíncronos. Basicamente, qualquer coisa que não precisa de resposta imediata.

Os padrões principais são Publish/Subscribe (um produtor, vários consumidores), Point-to-Point (uma mensagem, um consumidor) e Request/Reply (assíncrono mas com resposta).

As tecnologias mais usadas são RabbitMQ (versátil, confiável), Kafka (streaming, alto throughput), AWS SQS/SNS, Azure Service Bus, Redis Pub/Sub. Cada uma tem seu sweet spot.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

SAGA é um padrão pra lidar com transações distribuídas em microserviços. O problema clássico: cada serviço tem seu próprio banco, como você garante consistência numa transação que passa por vários serviços?

A ideia é dividir a transação em uma sequência de transações locais. Cada serviço faz sua parte e publica um evento/mensagem pro próximo. Se tudo der certo, ótimo. Se algo falhar no meio do caminho, você executa transações compensatórias pra desfazer o que já foi feito. É tipo um "rollback distribuído", mas manual.

Tem duas formas de implementar:

Na **Choreography**, os serviços conversam via eventos de forma descentralizada. Cada um escuta eventos e decide o que fazer. É mais desacoplado, mas vira um pesadelo rastrear o fluxo quando dá problema. A lógica fica espalhada.

Na **Orchestration**, você tem um orquestrador central que comanda cada passo da saga. Ele diz pro serviço A fazer X, depois pro serviço B fazer Y. O fluxo fica explícito e é mais fácil debugar, mas você cria um ponto central de controle.

Exemplo prático: pedido de e-commerce. Você cria o pedido, reserva o estoque, processa o pagamento. Se o pagamento falhar, precisa compensar liberando o estoque e cancelando o pedido.

É importante que tudo seja idempotente, porque mensagens podem ser reprocessadas. E aceite que é consistência eventual, não ACID. SAGA é complexo, só use se realmente precisar de transações distribuídas.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps é basicamente usar o Git como fonte única da verdade pra toda sua infraestrutura e aplicações no Kubernetes. A ideia é simples mas poderosa: tudo que roda no cluster está descrito em arquivos YAML no Git.

O fluxo funciona assim: você comita os manifests do Kubernetes (Deployments, Services, ConfigMaps, etc.) no Git. Um operator tipo ArgoCD ou Flux fica observando o repositório. Quando detecta mudança, automaticamente aplica no cluster. E faz reconciliação contínua - se alguém mexer manualmente no cluster, o operator reverte pro que tá no Git.

Isso traz vários benefícios. Todo deploy vira um Pull Request, então dá pra revisar, discutir, aprovar. O histórico completo tá no Git - quem mudou o quê, quando e por quê. Disaster recovery é só aplicar o repo de novo. Rollback é um git revert. Ambientes são totalmente reproduzíveis.

As ferramentas principais são ArgoCD (tem uma UI muito boa, suporta multi-cluster) e Flux CD (projeto da CNCF, mais leve). Ambos funcionam bem.

A separação fica clara: devs fazem PR com mudanças, ops revisa e aprova, operator aplica automaticamente. Ninguém dá kubectl apply manual em produção. Tudo rastreado, tudo versionado, tudo auditável.

É tipo Infrastructure as Code levado ao extremo. Git vira o controle de estado do cluster inteiro.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

Meu maior case de sucesso foi liderar uma evolução tecnológica completa em um projeto corporativo. A situação era desafiadora: tínhamos sistemas legados em C# e Java que precisavam ser modernizados. Decidi arquitetar uma solução em microsserviços usando Node.js (Express) e .NET Core, além de migrar os frontends para Angular.

A escolha das tecnologias foi estratégica. Para serviços que precisavam de alta performance e baixo acoplamento, optei pelo Express - mais leve e rápido. Já para serviços que precisavam de integração SSO e comunicação com sistemas SOAP, o .NET Core fez mais sentido pela maturidade nessas áreas e melhor suporte a essas tecnologias enterprise.

Paralelamente, conduzimos a migração do banco de dados de Oracle para PostgreSQL. Essa decisão gerou uma economia significativa para a empresa e foi um dos fatores que nos rendeu um prêmio interno. O projeto foi tão bem-sucedido que o produto acabou sendo vendido para todas as outras unidades da companhia.

Numa segunda fase, fui responsável por migrar toda essa infraestrutura de on-premise (servidores físicos na planta de Timóteo) para Azure. Estruturei as pipelines de CI/CD usando Azure DevOps, containerizei tudo com Docker e orquestrei com Azure Kubernetes Service (AKS), criando ambientes separados para desenvolvimento, QA e produção.
