# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
O Twelve-Factor App é uma metodologia para construir aplicações modernas e escaláveis, especialmente voltadas para cloud. Ele define 12 boas práticas — ainda não decorei todas, mas conheço alguns dos principais fatores:

-> 1. Codebase: A aplicação deve ter uma base de código única, versionada, e que possa ser implantada em múltiplos ambientes. Ou seja, um único repositório por app.

-> 2. Config: Configurações (como strings de conexão e credenciais) devem ser externas ao código, geralmente em variáveis de ambiente. Isso evita acoplamento e facilita deploys em diferentes ambientes.

-> 3. Dependencies: A app deve declarar e isolar suas dependências. Por exemplo, no .NET usamos o *.csproj com os PackageReference para listar os pacotes NuGet necessários.

-> 4. Backing Services: Serviços externos, como bancos de dados, filas ou storage, são tratados como recursos anexados, acessados via URL ou string de conexão. Isso facilita trocar ou mockar.

-> 5. Build, release, run: São três etapas separadas no ciclo de vida. Primeiro você builda a aplicação, depois cria um release com config específica, e só então roda.

-> 6. Logs: Logs devem ser enviados para o stdout/stderr e não salvos em arquivos locais. Isso facilita o gerenciamento via ferramentas como ELK, Grafana, etc.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Ao meu ver são 4 camadas:
-> 1- Camada Ux/Ui: Que é o visual do sistema utilizado pelo usuario final.
-> 2- Camada de Aplicação: É a camada que fica as regras de negócio
-> 3- Camada de Dominio: Aqui fica também regras de negócio, só que ficam aquelas mais importantes que não podem de jeito nenhum ser visualizada pelo usuario final. (Eu geralmente não uso essa camada);
-> 4- Camada de Persistencia de dados: Onde fica a logica de acosso do banco de dados e implementação de Crud ou mapeamento para objetos


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
-> SOA: Arquitetura de monolito, com grandes serviços que fazem muitas coisas, focado mais em reutilização e integração;

-> Microserviços: Arquitetura voltada para pequenos serviços independentes, cada microserviço tem seu próprio banco de dados e ciclo de vida. Geralmente usa o Rest para comunicar entre os serviços.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
A API management pode ser camada ou ferramenta que é usado para gerenciar APIS, parte de criação, publicação, monitoramento e etc.
->Vantagens: Uma das principais acredito que seja a centralização da gestão das Apis em um só lugar, ajuda bastante com a documentação, e tudo aquilo que é isolado é mais facil de dar manutenção.

-> Desvantagem: Claro o problema de tudo aquilo que se isola, configuração e responsabilidade e muita das vezes custo adicional, na maioria dos casos.
Na minha opinião é sempre um jogo de cara o coroa dependendo da realidade. Se for algo que 
compense e quer algo mais seguro e estrturado lógico que compensa.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Os dois são usados para criar objetos, o sTruct ele é gerenciado pela stack, é mais performatico que a classe que é gerenciada pelo Garbat Collector (Acredito ser esse o nome). Em resumo tem diferença no gerenciamento de memória, as vezes compensa mais o struct para melhorar a performance da aplicação.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET é usado mais pra legado, é a versão mais antiga do .NET.
.NET Core é a versão open source do Asp.net, além de ser multiplataforma.
Tem algumas diferenças de sintaxe e construção, como por exemplo a questão de comunicação com o banco, declaração de variaveis e facilitadores como interpolação. O unico que esta recebendo atualização se não me engano é o .NET Core.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
Eu conheco mais o REST que é toda parte de GET, POST, PUT e Delete e os formatos de comunicação JSON ou XML.O GRPC eu não conheço.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
A SPA é um gerenciamento de rotas, ela usa do histórico do navegador ou de algum hash da url para monitorar as mudanças de telas, ajuda a ter uma experiencia mais suave na hora de navegar, ela evita carregamentos, e também da pra colocar autenticação nessas rotas. O angular tem bastante disso no RouterModule

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Eu ja tive contato com a plataforma em uma empresa que participei, com gestão de wikis, a parte de pipelines pra fazer automatização de builds e gestão de sprints

10. Explique sobre um método agile.

**Resposta:**
Métodologia agil nada mais é do que uma organização na hora de desenvolver um software, tanto na parte de gestão de Código, time e tempo. Eu trabalhei com scrum, então tinhamos toda a parte de daily, planing, code review e até tinhamos reunião semanal com a diretoria.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI é Integração continua; CD é Entrega Continua;
CI é automatizar build a cada commit por exemplo, para acompanhar em tempo real e ter tempo para identificar os problemas o quanto antes.
CD é automatização do deploy da aplicação seja pra homolog ou para produção.
Eu em projetos pessoais faço essa parte no BitBucket para automatização de deploy;

12. Qual a diferença entre Docker e Containers.

**Resposta:**
O Docker ele é a ferramenta em si pra gestão dos containers. Containers são pacotes de aplicações que a gente cria pra nivelar ambientes de desenvolvimento.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Ambas são plataformas de gerenciamento de containers, é que Openshift foi construido com base no Kubernets, que é uma plataforma desenvolvida pela google.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
-> Vantages: 
    - APIS servem para comunicar serviços para diferentes sistemas.
    - Reutilização de código por conta da comunicação independente do serviço
    - Da pra escalar de maneira individual com base nas demandas ou criação de features;

-> Desvantagens
    - Segurança sempre é uma desvantagem quando se fala de expandir serviços, com API não seria diferente;
    - Documentação é uma dificuldade também, muitas apis não tem, e fica mais dificil na questão de se comunicar ou até mesmo na questão de manutenção.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Acho que tem algumas coisas que já são senso comum pra garantir segurança de API:
-> HTTPS: esse tem que ter, sertificado SSL para comunicações HTTP;
-> Tokens Criptografados: Tokens enviados via cabecalho de requisição ajudam a garantir a seguranã da comunicação;
-> Tokens com tempo de expiração: Esse também ajuda para garantir uma comunicação mais segura ainda;
-> Rate Limiting: pra impedir ataques DDos, limitar o numero de requisição por usuario.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Mensageria serve para criar filas de requisição de ações, muito utilizado em arquiteturas de microserviços. E o principal, desacopla a comunicação entre sistema e serviço, mas pra mim o principal é a distribuição de carga, para processos demorados.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A estratégia saga nada mais é que uma forma de lidar com transações distribuidas, diferente de um monolito que tem apenas uma unica transação de banco a estategia saga é dividir essas transações por etapas, cada uma executa uma ação local, as vezes ja sabendo o
que fazer de pois de finalizar ou as vezes com um orquestrador central (Orquestrada, Coreografada);

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é um gerenciador de infraestrutura e código, quando utilizamos o kubernets toda a parte de services e deployment é versionado em um repositorio Git atraves de um pull request; 

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Teve um case de sucesso que o desafio foi realmente tirar do zero e fazer todo o projeto, utilizei .Net Framework pro back-end, HTML, CSS e js para o front e SQL Server para o banco de dados. O sistema chama ReportIEQ, inclusive esta na web (https://www.reportieq.com.br). Os desafios foi criar a ideia, idealizar o front-end, construi de uma maneira escalar, gerenciar acessos, alem de atendimento e suporte ao cliente, treinamentos e negociação. 
Na parte técnica não encontrei tantas dificuldades, acredito que a principal foi a questão da gestão de perfis dentro da plataforma e definição de regras que existiam implicitamente, então alteração do código aplicando regras sem impactar no uso geral foi dificil, mas ta la, ta rodando rsrs.