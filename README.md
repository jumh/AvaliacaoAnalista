# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

2. Quais são as principais camadas no desenvolvimento de um software?
   

**Resposta:**
Seguir o príncipio SOLID e clean code

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
Em Arquitetura microserviços podemos ter vários containers aplicando vários serviços onde eles são isolados e posso ter diferentes tecnologia rodando em cada container e conversando entre si uma das características é que se uma parte falhar a outra continua funcionando sem a necessidade de parar o serviço todo, em Arquitetura SOA temos um serviço só onde a implementação é mais fácil, porém se uma parte falha todos falham também.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Uma API é onde o serviço se comunica, por exemplo posso ter a comunicação com o banco de dado em SQL Server e através da estrutura genérica e formando a camada de Repository, Service e Controller através de chamada assincrona e enviar o dado através do Json para que outro serviço se comunique com ele.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Uma class é a estrutura da linguagem onde posso armazenar propriedades, diferentes estruturas de repetição e onde posso instanciar a classe para ser chamada em outra classe.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET é a linguagem referenciada para a Web e o CORE seriam a referencia que posso utilizar de bibliotecas como Entity Framework Core para fazer a abordagem de code first onde estruturamos a classe com suas propriedades e rodamos a migration e update database para assim criar o banco de dados e cada tabela referenciada pela classe e seus relacionamentos através do código.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST é a arquitetura usada na API RESTFUL onde a comunicação entre eles é de maneira fluída.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**


10. Explique sobre um método agile.

**Resposta:**
SCRUM é uma metodologia ágil onde temos reunião diariamente onde falamos o que fizemos no dia anterior e vamos fazer no mesmo dia, temos a sprint composta entre 2 a 3 semanas para uma entrega de valor para produção, sendo dividido em tarefas com análise antes de backlog, em andamento, análise de teste e done como concluído.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia

**Resposta:**
Se refere a esteira em pipeline.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker é a imagem compilada do serviço que está a dispor como por exemplo node, wordpress e até o serviço .NET Web API. Já o container é a orquestração desses serviços podendo ser dividivo em vários containers.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é a arquitetura para a organização dos containers que podem ser divididos em vários e cada um com alguma tecnologia separada.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
A API é uma boa vantagem quando queremos ter essa comunicação com o banco de dados, usando como já citado anteriormente essa camada de Repoditory, Service e Controller utilizando a injeção de dependencia e ORM Entity Framework Core para o banco e assim podemos ter todo o desenvolvimento e chamada no banco em fácil acesso e fácil implementação se for o sistema monólito, podendo fazer assim alguma chamada no banco e relacioanando várias tabelas com o Include(). A desvantagem segue pela performance dessa arquitetura, pois quando chamamos várias tabelas interligadas, a demora pode persistir. 

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
A parte da segurança se faz onde a comunicação com o banco de dados é interna e aquilo que a gente expoe é por exemplo alguma DTO com as propriedades e características que a gente escolhe e assim não precisa enviar diretamente aquilo que está no banco de dados.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
A mensageria chegou para melhorar essa dafasagem de espera em cada chamada. Com isso, é possível enviar alguma requisição - ela entra na fila e assim que possível ela é então validada e executada - tornando o sistema sem ficar esperando ou travamento em algum momento.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Na empresa em que eu atuava tive que fazer um endpoint de Web API .NET para contratos, o problema é que tinham muitos campos a serem preenchidos nesse formulário para o envio da API. O que desenvolvi foi a parte do CRUD da API com a tabela em si. E depois realizei o GetALL de relatório cruzando dados de várias tabelas para a entrega de valor. A tecnologia usada foi .NET Web API - SQL Server.

