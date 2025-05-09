# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
	- Base de Código:
		* Uma base de código com muitos deploys.
	- Dependências:
		* Dependências declaradas e isoladas.
	- Configurações:
		* Configurações armazenadas no ambiente.
	- Construa, Realese, run:
		* Builds separados e executados em estágio.
	- Descartabilidade:
		* Inicialização e desligamento rápido maximizados.
	- Dev/Prod semelhantes:
		* Tarefas de administração/gerenciamento executadas como processos pontuais.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Front-End (Visual/Apresentação), Back-End (Lógica) e DataBase (Dados).


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** A arquitetura SOA visa a construção de aplicações como uma coleção de serviços, já a arquitetura de microserviços é uma evolução da SOA com foco em serviços menores.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** O objetivo é fornecer controle sobre a comunicação dos sistemas, algumas vantagens são:
		        * Segurança;
		        * Monitoramento;
	          Algumas desvantagens são:
		        * Complexidade de Implementação;
		        * Desempenho;


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Struct permite realizar cópias de estruturas de dados enquanto a Class não permite, além disso o Struct não tem herança.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** .NET só pode ser utilizado para a plataforma Windows enquanto o .NET Core é multiplataforma. 


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** A REST é unilateral já o gRPC é uma comunicação bilateral. Além disso o gRPC sempre usa HTTP2 enquanto a REST usa o HTTP1.1!


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** O conteúdo da página é atualizado conforme a rota que o usuário estiver utilizando. 


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** Tenho conhecimento com contêiner Docker e plataforma de nuvem Azure.


10. Explique sobre um método agile.

**Resposta:** O Kanban é um método de gerenciamento de tarefas onde temos uma visualização gráfica da etapa em que cada tarefa está.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI é integração contínua e CD é entrega contínua, no Azure associado ao repositório tem o pipeline CI para build da aplicação e o pipeline CD para publicação da aplicação.


12. Qual a diferença entre Docker e Containers.

**Resposta:** Docker é a plataforma que facilita a criação e gerenciamento de Containers, enquanto o Container é um ambiente isolado que permite a execução de aplicações e suas dependências.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Kubernetes é uma plataforma que automatiza a implantação, gerenciamento e escalonamento de containers, já o Openshit utiliza o Kubernetes para orquestração de container.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** A principal vantagem é a modularização do seu back-end para a aplicação enquanto a desvantagem é a complexidade em relação a segurança que também já conta como uma grande preocupação.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Utilizar Criptografia, autorizações e autenticações, além disso o monitoramento para identificar possíveis vazamentos ou arquivos maliciosos é essencial.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Comunicação entre duas ou mais aplicações por meio de eventos através de sistemas de mensageria, como por exemplo o RabbitMQ.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** A estratégia SAGA consiste em duas partes, sendo elas: Coreografia e Orquestração.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** O Git armazena toda a configuração do cluster, garantindo mais segurança.


19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Desenvolvi um sistema de gerenciamento agrícola usando C#, .NET Core e MySQL, com módulos para Controle de Estoque, Pragas, Irrigação, entre outros. Um dos maiores desafios foi otimizar as consultas SQL para processar grandes volumes de dados em tempo real, solução que implementei através de stored procedures e indexação estratégica. O projeto foi desenvolvido do zero atendendo às especificações disponíveis no escopo encaminhado pelo cliente.