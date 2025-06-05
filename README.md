# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta: Infrastruceture, Domain, Aplication


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** o SOA se não me engano, o objetivo é separar serviços para serem reutilizaveis e os microserviços, são serviços menores e mais especificos.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**


5. Qual a diferença entre uma Struct e uma Class?

**Resposta: Se não me engano é relacionado a memoria, a Struct está na memoria stack e a class está na memoria heap


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta: Não sei se entendi bem a pergunta por que antes tinhamos o .NET Framework e o .NET Core, aonde o Framework era apenas para windows e o Core era multiplataforma. Até aonde eu saiba, a microsoft unificou isso e hoje chamam apenas de .NET


7. Quais as principais diferenças entre REST e GRPC?

**Resposta: A padrão REST é via comunicação HTTP/HTTPS e o CRPC é uma comunicação mais usada entre microserviços dentro da mesma network.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta: 


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta: Tenho um bom conhecimento sobre docker, criação de volumes, docker-compose. Tenho um conhecimento de kubernets mas mais voltado para estudo por que em sistemas em produção, usei apenas o Docker


10. Explique sobre um método agile.

**Resposta: Temos o SCRUM que tem suas rotinas como Daily que são reuniões diarias de até 15 min. Funciona tambem no modelo de sprint aonde podemos ter sprints de 15 ou no máximo 20 dias. Temos a Planning tambem que seria o planejamento, geralmente da próxima sprint e na retro que é feita no Final da sprint, vemos a evolução do time. Temos a presença do Scrum Master que é um "facilitador", fazendo a verificação das tarefas e ajudando o time para que não haja impeditivos.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

12. Qual a diferença entre Docker e Containers.

**Resposta: O Docker é uma ferramente para criar Container. Um container é um conjunto de ferramentas para rodar uma aplicação


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Eu nunca usei o OpenShift, preciso estudar para saber as diferenças


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** Uma vantagem é a reutilização de endpoints, sendo que podemos ter mais de um site que acessa o mesmo endpoint, ou varios aplicativos. mas como se trata de uma transação HTTP, se torna mais facil para alguem mal intencionado, achar brenchas ou informações que ele não deveria ter acesso. 


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Trabalhar sempre com autenticação e autorização, é uma forma boa de saber se o usuário está logado e se ele tem acesso aquele recurso. Tambem garantir que as transações sejam feitas em requisições HTTPS, ter uma boa finição de CORS para que apenas aplicações previamente autorizadas, possam fazer requisições.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Um dos motivos principais é para que não haja forte acoplamento entre serviços ou seja, ao invés de um serviço depender da resposta do outro, ele pode funcionar de forma independente, enviando as informações via serviço de mensageria sem a necessidade de saber se o serviço está disponivel ou se o outro serviço conseguiu consumir com sucesso a mensangem.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** Não conhecço sobre essa estrategia. Preciso estudar.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** Não vou conseguir explicar nesse momento, sem pesquisar.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Um aplicativo de celular em React Native, ele tirava fotos de documentos e subia para a API de OCR do Google. Mas como esse processo de validar o documento era posterior a execução de tarefas, havia um problema de varias imagens estarem erradas. Eu dei a sujestão de trazer essa funcionande localmente, sem a necessidade da API do google. O Desafio foi fazer isso, mesmo sem ser a linguagem que eu tenho mais facilidade e ter poucas informações de como fazer isso. Mas continuei testando alternativs e consegui trazer a funcionalidade.
