# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** Não estou famialirizado com a metodologia/framework twelve-factor app.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** 
As principais camadas no desenvolvimento de software são: Presentation, Application, Infrastructure e Domain; A camada de presentation é a interface com a qual o usuário interage diretamente (seja uma tela ou uma API); a camada Application é a camada responsável pela orquestração do fluxo de dados, conexão entre as camadas e com frequência pela conversão de dados de uma camada para outra, por exemplo uma viewmodel para model e vice-versa, a camada de infra serve para fazer a conexão com serviços externos ORM(entity/dapper), mensageria (RabbitMQ/AWS SQS) e implementar abstrações definidas na camada domain, a qual por sua vez, serve para definir as lógicas internas da aplicação (frequentemente de forma que não dependa das implementações externas feitas na camada de infra), o domain é onde vivem as regras de negócio. Alguns desenvolvedores usam uma camada a mais, as vezes chamada de services, mas cujo nome varia, para armazenar lógicas de clientes específicos de forma a isolar estes usos das outras camadas.

Atualmente sou responsável por dois projeto em .Net os quais são divididos em camadas, sendo um deles um projeto de API, e o outro um projeto MVC, model view controller, no entanto, ambos os projetos compartilham as camadas de application para baixo, apesar de terem camadas de apresentação diferentes.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** SOA significa Service oriented application, um projeto criado nesta arquitetura tem serviços reutilizáveis (não monolítica), mas possui um orquestrador entre os serviços, o orquestrador tende a ser o ponto de acesso e comunicação entre os serviços, enquanto uma arquitetura de microserviços os serviços são independentes um do outro, se comunicando entre si, sem a necessidade de um orquestrador para fazer essa comunicação. O deploy de SOA é o deploy da aplicação toda, enquanto microsserviços costumam ter deploys independentes um do outro.

Nunca atuei usando SOA, apesar de estar familiarizado com o modelo, porém, já realizei projetos em microserviços, e transformação de projetos monolíticos em projetos de microserviços, procurando principalmente a independencia de componentes no sistema. Por exemplo, um sistema de calculo de comissão e um sistema de gestão de posts em um mural, apesar de estarem relacionados, pois são acessíveis na mesma aplicação, a independencia dessas duas partes do sistema uma da outra facilita o desenvolvimento e segrega projetos. 

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** o API management é um centralizador de funções em arquiteturas de serviços, funciona como uma porta de acesso para os serviços, as principais vantagens são que neste caso é possível fazer implementação de funções que seriam usadas por todos os serviços uma única vez no centralizador, autenticação, log, etc, porém um erro no centralizador pode derrubar ou tornar inacessível todo o conjunto de serviços.  

Acho que o exemplo de uso mais comum é realmente fazer o processo de autenticação para acesso a microsserviços.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Structs são semelhantes a classes, porém são menores, não possuem herança e são armazenadas na memória stack e por tanto ocupam menos espaços. São objetos do tipo valor e não do tipo referência como as classes

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
O .Net (Framework) tem código proprietário e só funciona no windows, além de estar depreciado. O .Net Core é multiplataforma e open source.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
Não conheço GRPC, mas o REST é um padrão de criação/estruturação des APIs que faz uso dos "verbos" do HTTP: Get, Post, Put, Delete

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O gerenciamento de rodas em uma SPA funciona realizando somente a atualização em tela dos aspectos que mudaram, carregando somente os componentes necessários, sem necessariamente recarregar toda a página. Exemplos são o router do react e do angular.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é o conjunto de práticas e estratégias para integração e deploy do código de forma mais eficiente, o qual no geral consiste de o desenvolvedor realizar o push do código para um repositório, ter um serviço que realiza builds e testes automáticos, realiza o merge com base nos testes, realiza-se o deploy para staging (fase intermediária), testes de integração e se aprovados deploy em produção. Historicamente o DevOps foi uma função separada na equipe, nos ultimos anos o papel de DevOps tem se fundido ao de de Full Stack na ideia de "Full cycle".

10. Explique sobre um método agile.

**Resposta:**
O agile é um conjunto de práticas de gestão de projetos baseado no manifesto agil o qual busca fazer entregas continuas e incrementais do projeto, se opõe ao método em cascata (waterfall) de planejamento e outros métodos, onde as etapas de planejamento, execução e entrega são claramente separadas, no agile, as entregas são separadas em sprints (períodos curtos de tempo), com etapas definidas no geral em back log, próximas atividades, em execução, em testes e entregue (kanban). O agile tem papeis bem definidos como product owner, responsável pela gestão do back log e dos critérios de aceite e scrum master, o qual ajuda a resolver possíveis dificuldades na sprint e time de desenvolvimento. Ao contrário do método em cascata, o planejamento no método agile ocorre no fim e inicio da sprint e não só no ínicio do projeto. Porém  nem sempre o método agile é implementado inteiramente, sendo possível implementações parciais com base nas equipes e necessidades.
 
11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI e CD sigificam respectivamente integração contínua e deploy continuo. Em essência são práticas para automatizar a integração de código de desenvolvedores em um repositório comum e acessível e automatizar o deploy (entrega). Pipelines de CI/CD costumam também envolver testes automatizados (xUnit, Moq) ou análise de códigos (com ferramentas como SonarQube). Acredito que as ferramentas mais comuns de CI/CD hoje em dia sejam o Jenkins, que é mais antigo, mas tem self host, e o GitHub Actions, o qual é integrado ao GitHub. 

Atualmente a pipeline de CI/CD da área de TI onde trabalho usa Jenkins como principal ferramenta, usamos também o SonarQube para análise.

12. Qual a diferença entre Docker e Containers.

**Resposta:** O docker é uma ferramenta para criação e gestão de containers em uma máquina, mas ele em si não é um container, um container é um ambiente isolado o qual tem tudo o que é necessário para uma aplicação rodar.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** O Kubernetes é uma ferramenta opensource de orquestração de clusters (containers em diversas máquinas), serve para implantar containers e fazer, escalamento deles e a monitoração dos pods. O OpenShift é uma plataforma, a qual inclui em si o kubernetes, mas o qual inclui outras funções, as quais eu não saberia elencar, pois não estou intimamente familiarizado com a plataforma. 


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
A principal vantagem de criação e uso de uma API é desaclopar o sistema e possibilitar que ele seja utilizável por diferentes frentes, os quais podem consumir a mesma API, tem a função central de possibilitar a integração de multiplos sistemas. Porém, uma API, ainda mais se publica, exige um cuidado grande com a segurança dos dados, os quais devem ser encriptografados onde necessários e estarem atrás de um sistema de autenticação também quando necessário, e um alto consumo de uma API pode levar a sobrecarga de um servidor ou a um custo alto, caso exista um auto scalling.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Implementar autenticação (JWT, Oauth2 ou Bearer). Implementar um sistema de autorização com base em roles para definir o aspecto de uso e nível de acesso dos dados quando necessário. Usar criptografia para dados sensiveis, e implementar rate limiting, para limitar requisições desnecessárias. Além disso, criar sistemas de log e de versionamento.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Serve para que sistemas com serviços independentes se comuniquem de forma assincrona, no geral por uma estrutura de "fila", sem uma estrutura de requisição-resposta. Então um publisher cria uma mensagem, a qual vai para um serviço de fila, como por exemplo o Azure Service Bus ou RabbitMQ (chamados broker), um outro serviço consome essa fila e executa uma ação.

Um desenvolvimento recente que realizei utilizando mensagerias foi a criação de um sistema de fila da vez, sistema comum em varejo onde um vendedor fica na porta da loja para atender um cliente e quando ele está atendendo um cliente, registra no sistema que está atendendo, o próximo vendedor recebe uma notificação de que a frente da loja está vazia, então ele deve assumir e o terceiro vendedor recebe uma notificação para se preparar. Caso o cliente faça uma compra no caixa, é registrado no sistema a compra e o vendedor, e o vendedor é liberado da atribuição com aquele cliente e é reinserido na fila da vez, ou caso o cliente não faça uma compra, o vendedor em questão deve interceptar o cliente (se possível) para registrar o motivo da não compra. Usei o SQS da AWS para a gestão de mensageria, para que os eventos fossem processados de forma assincrona. 


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** É uma forma de gerenciamento de transações em microserviços, o qual ao invés de utilizar um banco de dados único centralizado, possui uma gestão de transação "local" no microserviço, onde cada microsserviço dispara uma "notificação" após um evento e caso todas as transações tenham cido executado com sucesso, o processo chega ao fim, caso haja uma falha é realizado um rollback das etapas, sem o commit das transações, além de outras tratativas com base nas regras específicas do contexto. 

Apesar de conhecer a estratégia, nunca implementei.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** O GitOps é uma abordagem onde todos os aspectos estão centralizados no Git e toda alteração em um cluster kubernetes é feita por meio de commit no Git, no geral em arquivos yaml. Apesar de saber da existência desta abordagem, nunca apliquei ela e não conheço seus meandros.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Um case de sucesso recente foi a implementação de um sistema de gestão de PDFs para treinamento, o qual foi uma solicitação de um cliente o qual gostaria de criar PDFs informativos e disponibilizar para os funcionários, no entanto, havia a preocupação de onde armazenar estes PDFs, os quais poderiam vir a ser em grande quantidade e peso (dependendo da qualidade de imagem, etc) e como não gerar uma sobrecarga no servidor ao realizar o fluxo destas transferências. A aplicação usada para subir e baixar os PDFs é uma aplicação em Angular 19, com um back end monolítico em .net 4.5. Para este processo foi desenvolvido um novo conjunto de end-points em uma controller, para receber os PDFs, os quais recebem uma chave composto de identificação única id_cliente + id_treinamento, a qual seria armazenada no banco de dados e usada como identificador em um bucket do S3 da AWS, onde o PDF foi armazenado. Quando um usuário baixa a primeira vez o PDF, armazenamos o identificador único do dispositivo do usuário, assim como o id de usuário e do PDF. Na próxima vez que ele fosse baixar o PDF estando no mesmo dispositivo, usei o Capacitor Filesystem Plugin para verificar se o arquivo existia, caso não fosse encontrado, baixava de novo, caso contrário abria o PDF já baixado.
