# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

(Codebase) Base de código: Uma base de código, com vários deploys. Usando ferramentas como git é possível versionar e rastrear a base de código,
cada deploy é separado em seu ambiente especifico (produção, homologação, dev etc) porém mantendo a consistencia e facilitando a manutenção.

(Dependency) Dependências: Declaração explícita e isolada de dependências, dando resonsabilidade e poder de gerenciamento para a própria aplicação
e assim garantindo portabilidade e facilidade de configuração entre desenvolvedores diferentes.

(Config) Configurações: Tudo que pode variar entre os deploys e ambientes, como credenciais de acesso, connection strings de bancos
e outras variavéis de ambiente.

(BackingServices) Serviços de apoio: Qualquer serviço que o app vai consumir para operar normalmente, como bancos de dados (ex: SQL, MongoDB), ferramentas de cache (ex: Redis), messageria (ex: RabbitMQ) e afins

(Build, Release, Run) Construa, Lance, Execute: Separação estrita dos estágios para deploy, durante a construção com o código de um repositório
um pacote executavel é gerado, durante o lançamento a construção se une a suas configurações especificas de deploy e por fim vem a execução quando o app roda em si no seu ambiente destino.

(Dev/prod parity) Paridade dev/prod: Os ambientes de produção, homologação e desenvolvimento apesar de separados devem estar o mais pareado/semelhantes possível,
usando ferramentas de deploy continuo (CD) para reduzir lacunas como tempo ou no gerenciamento de deploys.


1. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Camada de interface do usuário/apresentação: Interfaces graficas, apps e outras formas de interação direta com o usuário.

Aplicação: Camada de serviço onde esta a lógica de negócio, processamento de dados, validações e outros comportamentos inerentes aos contratos do sistema.

Persistência: A camada que envolve diretamente com implementações de armazenamento, consultas, atualizações e outras operações com dados. Sendo ligada
diretamente com bancos relacionais e não relacionais, messageria, cachea e afins.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Microserviços: Envolve granulação e separação de funcionalidades, onde cada um pode sofrer mudanças mais específicas e isoladas
sem necessáriamente um microserviço depender do outro. A manutenção em um microserviço não impacta o sistema por completo e existe uma flexibilidade
em como cada um pode ser escalado.

SOA: Com regras mais definidas onde um barramento de serviços (EBS) controla os serviços, diferente da arquitetura de microserviços na SOA os serviços tem
recursos compartilhados o que garante consistência entre os dados trafegados entre eles.

1. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Struct: Tipo valor, armazenado na memória stack, suas istancias tem valores exclusivos e únicos.

Class: Tipo referencia, onde uma referencia é guardado na memória heap, suas instancias tem as mesmas propriedades e ao
modificar a propriedade de uma as outras instancias também são alteradas, porém valores diferentes podem ser atribuidos a propriedade de cada instancia.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET framework é o framework original, considerado legado, não é muiltiplataforma. O .NET CORE é multiplataforma e open source.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

Diferente do REST, GRPC oferece streaming bidirecional, na mesma conexão o cliente e o servidor podem enviar e receber solicitações. Por outro lado REST é
menos aclopado, permitindo que um serviço ou o cliente não precisem saber sobre como funcionam as implementações um do outro, permitindo que você faça a manutenção separadamente.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Quando um usuário navega em uma SPA, ao acessar uma rota o navegador não recarrega por completo, seu comportamento padrão é impedido e a aplicação
renderiza na tela o componente especifico definido no mapeamento das rotas e dependendo do gerenciamento de estado da página.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps vem de development operations, é forma de estruturar e melhorar a eficiencia do desenvolvimento ao deploy em si. Focam em monitoramento, CI/CD,
desempenho das configurações e oferecem suporte geral em tudo que envolva a infraestrutura do software em si.

10. Explique sobre um método agile.

**Resposta:**

O método Scrum, é um framework agile onde são definidas sprints curtas (geralmente 1 ou 2 semanas) com objetivos especificos e definidos, existem reuniões de acompanhamento como as dailys para mapear o que está sendo feito e o que é preciso para fazer caso esteja com tarefas impedidas, reuniões de planejamento (onde são definidas as tarefas que vão ser realizadas, por quem e em quais estimativas), e tambem reuniões de finalização como a Review, onde avaliamos se os objetivos definidos na planning foram cumpridos.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI/CD vem de integração e entrega continua, é parte das funções primárias dos DevOps porém afeta todo o time de desenvolvimento. Vem muito da automatação do deploy e entregas mais frequentes e constants, permitindo mais agilidade nas entregas e garantindo um padrão. Ferramentas que utilizo no dia a dia seria o bitbucket pipelines para automatizar a geração de imagens para atualizar e construir constainers no Jenkins.

1.  Qual a diferença entre Docker e Containers.

**Resposta:**

Containers são processos com recursos isolados para aplicações especificas, encapsulando a aplicação e suas dependencias. O Docker é uma plataforma onde podemos executar, configurar e gerenciar esses containers.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Os 2 são plataformas de gerenciamento de containers, sendo o Kubernetes open source e o Openshift o tem como nucleo, porém é bem mais robustos tendo funcionalidades extras como CI/CD integrado e politicas de segurança mais fortes.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

Entre as vantagens a facilidade de reutilizar APIs em contextos variados, modularidade que facilita a manutenção e oferece flexibilidade em atualizações e no desenvolvimento. Algunas desvantagens seriam que elas são grandes pontos de preocupação de segurança já que são a porta de entrada para um sistema (por meio de endpoints) e também existe uma grande preocupação em questão de performance.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Monitorando o desempenho e funcionamento das APIs, implementando práticas robustas de autenticação, permissionamento e criptografia, implementando testes para garantir um comportamento previsivel e que pode ser documentado.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Arquitetura de mensagerias oferece principalmente assincronicidade por meio de filas configuraveis, permitindo que o sistema fique mais fluido e não precise esperar pela resposta para continuar o funcionamento, as filas também facilitam a coordenação de processos diversos entre sistemas, separando em contextos e oferecendo opções de redundancia em caso de falhas o que provê resiliencia para o sistema.

1.  Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
