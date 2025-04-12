# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** Não me recordo de cada um dos 6, mas vou citar ao menos 3 que eu lembro e uso no dia a dia: 1. Ambientes de desenvolvimento e produção o mais idênticos possíveis, facilitando a identificação de problemas, bem como a correção de bugs; 2. Definir e gerenciar dependências do projeto, de preferência usando uma ferramenta para isso, como o Nugget ou npm; 3. Utilizar controle de versão nos projetos, definindo estratégias de ramificação. A última vez que ouvi falar nesses conceitos foi durante a graduação.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Em alto nível, na minha visão existem 3 camadas bem definidas de desenvolvimento de software: frontend, backend e banco de dados. O frontend é responsável pela apresentação de exibição do software, bem como pela lógica responsável por isso. O backend é responsável pelas regras de negócio, de acesso e processamento dos dados. O banco de dados é responsável pelo armazenamento e manipulação direta dos dados, geralmente por meio de alguma linguagem de consulta estruturada.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** SOA é um padrão orientado a serviços, utilizado principalmente para integrar aplicações corporativas, utilizei bastante durante minha experiência trabalhando no setor Siderúrgico, integrando o sistema de controle de produção com o sistema SAP, utilizando o protocolo SOAP com xml. Também trabalhei na minha experiência recente operando com sistemas do tribunal de justiça, o Conselho Nacional de Justiça disponibiliza um Modelo Nacional de Interoperabilidade nos sistemas dos tribunais de justiça do Brasil, esse modelo é um webservice SOA, utilizando o padrão SOAP. Já a Arquitetura de microserviços é mais moderna, com componentes mais especializados em realizar determinada ação. Os serviços geralmente se comunicam usando mensageria, como RabbitMQ, Kafka, Azure Service Bus ou outra ferramenta. Atuei com migração de um sistema monolítico para microserviços durante minha experiência no Instituto Eldorado, onde tive a oportunidade de participar das reuniões técnicas para a definição dos componentes independentes do sistema, ou futuros microserviços.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** O principal objetivo é centralizar o gerenciamento dos multiplos serviços. O objetivo de uma API Management é sua principal vantagem, como desvantagens temos: único ponto de vulnerabilidade, se houver alguma vulnerabilidade de segurança no management, todos os serviços moniturados podem ser afetados; sobrecarga nos usuários dos serviços, haja vista que se o Management fazer a função de Web Gateway, a requisição para um serviço específico pode ir diretamente para o gateway, depois ir para o serviço.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Structs são tipos que armazenam valores, como um tipo primitivo no C#; Classes são tipos que armazenam referências de objetos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** .NET é a versão tradicional para Windows; .NET Core é multiplataforma, mais leve e robusto.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** REST usa JSON com HTTP, é mais simples e amplamente usado; gRPC usa Protobuf com HTTP2, é mais rápido e eficiente.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** O gerenciamento de rotas em um SPA funciona por Javascript, apenas trechos da página são carregados quando uma rota é acionada, não há a necessidade de carregar a página inteira.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** DevOps é a integração entre desenvolvimento e operações, é um termo relativamente novo na área de tecnoligia, focando em automação, entrega contínua e colaboração contínua.


10. Explique sobre um método agile.

**Resposta:** Sobre o Scrum, a ideia é dividir o trabalho em ciclos de entregas pequenas, com avaliação e feedback constantes, além da colaboração entre o time scrum e os envolvidos.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI (Integração Contínua) focado em testes e integração de código; CD (Entrega/Deploy Contínuo) automatiza a entrega de determinada versão de software. Como ferramentas do dia a dia gosto muito de usar o gitlab com as actions, integrado as pipelines com SONAR CUBE, BLACKDUCK para a parte de CI e docker ou podman com kubernetes para a parte de CD.


12. Qual a diferença entre Docker e Containers.

**Resposta:** Docker é um serviço do sistema operacional Linux, que funciona por meio do system.d para acessar recursos de usuários, processos, namespaces e grupos de processos no sistema operacional. Um container pode ser iniciado por meio do serviço Docker, é representa uma instancia de uma imagem de um container em execução (um processo linux isolado que se comporta como se tivesse em um sistema operacional e com recursos isolados da máquina original). Tenho 3 certificações Redhat, isso me ajudou a entender mais desse universo de cloud e automação de deploy.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Kubernetes é uma ferramenta para controle e gerenciamento containers, ou pods. Openshift é uma versão empresarial do Kubernetes, que oferece uma UI e ferramentas que facilitam o uso do Kube, além de suporte corporativo da Redhat.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** Vantagens: integração entre sistemas, reuso, escalabilidade; Desvantagens: segurança, versionamento, latência, garantias de ACID; Cuidados: autenticação, limitação de acesso e documentação.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Por meio de autênticação (OAuth, JWT), HTTPS, validação de dados de entrada e controle de acesso (rate limit, CORS).


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Basicamente para comunicação assíncrona entre serviços, garantindo desacoplamento, escalabilidade e performance.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** Outro termo que eu não ouço falar formalmente a alguns anos. Fora as piadas com a empresa por trás dos jogos do Sonic no Super Nintendo (SEGA), é um padrão que define como garantir transações distribuídas entre microserviços, fornecendo etapas e compensações caso alguma dessas etapas falhe. É um desafio lidar com atomicidade em ambiente de microserviços, mas o padrão SAGA já nós dá um norte de como lidar com esse tipo de situação.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** GitOps é a materialização de repositórios e pipelines de git, que podem fazer o uso de validadores de imagem de versão, executando testes e verificações de segurança e também de ferramentas de deploy dessa imagem do software usando clusters de Kubernetes com podman.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Um case que entreguei recentemente foi a Plataforma de Personalização de Apartamentos da Hub2Decor (empresa na qual sou sócio) - https://hub2decor.com.br/

Quando cheguei na empresa em questão, já existia uma plataforma para gestão de personalização, mas era extremamente pesada, feita com a game engine Unity 3D, utilizando C# para o desenvolvimento. Os clientes reclamavam muito de lentidão ao acessar e navegar na pĺataforma e de falhas ao gerar os orçamentos do imóvel. Ademais, haviam dois desenvolvedores na empresa, 1 com perfil mais Jr e outro Pl, ambos com conhecimento em programação com Python. Na minha visão, que venho de C# .NET, entender a lógica de negócios da solução que já existe foi bem fácil. A minha primeira grande decisão foi: Aprender Python e desenvolver a plataforma com essa tecnologia ou ensinar C# para os outros Devs para criarmos em .NET. Eu optei por aprender Python, pois é já carregava algum conhecimento da linguagem que adquiri trabalhando no Eldorado em um grupo de pesquisa de IA generativa. 

Definimos as tecnologias do sistema como Python no backend e React no frontend. React é uma bibliteca, diferente de Angular que é um framework. Nesse sentido, tivemos que criar um motor de renderização 3D com react, eu optei por usar a biblioteca Threejs (https://threejs.org/) que oferece várias facilidades para acessar recursos 3D dentro do navegador WEB de forma leve. Além disso, com Python no backend tivemos acesso a bibliotecas para manipulação de imagens, eu desenvolvi um compressor que reduziu em até 300% o tamanho das texturas, sem perder a qualidade delas, utilizando bibliotecas como Pillow.

Como resultado, em 3 meses lançamos uma plataforma leve, responsiva e rápida. Só pra comparação, a plataforma anterior chegava a ocupar 600MB de RAM em uma aba de navegação, enquanto que a plataforma atual ocupa cerca de 50MB de RAM na mesma cena. Além disso, nossa cartela de clientes aumentou consideravelmente e fidelizamos clientes que queriam nos deixar devido a dificuldades na plataforma antiga.

