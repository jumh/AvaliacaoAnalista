# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** 1- CODEBASE -> Uma codebase deve ser unificada e comum para todos que estão participando do processo de criação do software. Além disso, a codebase deve ter um histórico de alterações e indicar quem fez e quando aquela alteração foi feita. Um exemplo é o Git, onde podemos ter multiplos ambientes (prod, homolog, develop) apontados para uma codebase e temos versionamento de código. 
2- Dependencies -> Todas as dependências do seu projeto devem ser declaradas para garantir que o ambiente de execução tenha tudo que a aplicação precisa. Ex: Uma API em Node, existe uma grande possibilidade de utilizar uma lib externa chamada Express. Nesse caso, o Express é uma dependência do projeto.
3- Config -> Configurações de ambiente devem ser armazenadas em variáveis de ambiente e não no código fonte. Ex: Acesso ao banco de dados, bucket de arquivos, chaves de acesso, esse tipo de informação não deve NUNCA ficar explícito no código, mas sim ser armazenado em variáveis de ambinete. 
4- Backing Services -> São serviços que são consumidos por uma aplicação principal para que esta funcione e desempenhe suas funções. Ex: Banco de Dados, serviços de cache, serviços de comunicação assíncrona como filas e tópicos.
5- Build, Release, Run -> Quando as aplicações são construídas, devem ser entregues através de operações de deploy. Para gerar o deploy, são necessários 3 estágios: Build (todo código presente na codebase é compilado e transformado em um executável), Release (o pacote da build é aplicado dentro de uma configuração específica) e Run (a aplicação é executada dentro da versão gerada no estágio de build e com as configurações definidas no estágio de release).
6- Processes -> A aplicação é executada como um ou mais processos sem estado, ou seja, qualquer dado persistente deve ser armazenado em um serviço externo, nunca na memória ou sistemas de arquivo local.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Camada de apresentação(Front) -> É responsável pela interação com o usuário. Camada de aplicação (Services) -> É onde fica armazenada as regras de negócio e lógicas principais do sistema. Camada de Dados (Repository) -> Gerencia o acesso ao banco de dados e outros recursos de armazenamento. Camada de Infra -> Dá suporte técnico as outras camadas, lidando com integrações externas, logging, etc.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** SOA é uma arquitetura onde aplicações são compostas por serviços independentes que se comunicam entre si. Na arquitetura de microserviços cada aplicação é dividida em pequenos serviços independentes, cada um sendo responsável por uma funcionalidade específica e executando seu próprio processo.  


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** O objetivo principal é centralizar, controlar e facilitar o acesso e o monitoramento as APIs que são utilizadas para integração entre sistemas, clientes e parceiros. Ele funciona como uma camada intermediária entre consumidores e os criadores das APIs. Algumas vantagens do API management são: Segurança, padronização, governança, escalabilidade. Desvantagens: Complexidade visto que adiciona uma camada a mais à arquitetura; A solução de API management pode trazer um custo a mais também se tiver uma infraestrutura dedicada, latência adicional nas requisições, ponto único de falha. 


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Struct são tipos de valor e são usadas para armazenar somente dados enquanto que a class são tipos de referência e são mais apropriadas para armazenar tanto os dados quanto seus respectivos métodos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** O .NET é a versão original e mais completa enquanto que o .NET CORE é uma versão mais atual, open-source e modular. O .NET CORE é mais leve e é projetado para o desenvolvimento web moderno, sendo a base do novo framework ASP.NET, enquanto que o .NET é mais pesado e robusto, sendo uma escolha ideal para projetos que precisam de uma solução completa.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** REST usa protocolo HTTP/1.1, JSON como formato de dados, verbos HTTP (get, post, put, delete) e é altamente suportado por navegadores. gRPC usa o protocolo HTTP/2, Protocolo de buffers que é binário, compacto e eficiente, não é nativamente suportado por navegadores sendo utilizado mais para comunicação entre sistemas, microsserviços e backend.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** O gerenciamento de rotas funciona de maneira que, ao navegar entre diferentes seções ou páginas da aplicação, não seja necessário recarregar toda a página do navegador devido ao sistema de roteamento que obser as mudanças no endereço da URL, seja por meio do uso do hash ou utilizando a API de History do navegador. Quando o usuário realiza alguma ação que deve levá-lo a uma nova página, o roteador identifica qual componente deve ser exibito para aquela rota e faz a substituição apenas do conteúdo relevante na tela. Além disso, o roteador pode gerenciar parâmetros de rota e informações adicionais na URL, permitindo, por exemplo, carregar detalhes diferentes de acordo com o recurso acessado.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** DevOps é a combinação de filosofias, práticas e ferramentas que aumentam a capacidade de uma empresa de distribuir aplicativos e serviços em alta velocidade, otimizando e aperfeiçoando produtos em um ritmo mais rápido do que de empresas que usam gerenciamento de infraestrutura tradicionais. Ao meu ver, o devops é muito importante pois garante que os softwares fornecidos pela empresa sejam mais eficientes e estejam disponíveis de forma rápida e reduz consideravelmente as falhas, aumentando a qualidade do software.


10. Explique sobre um método agile.

**Resposta:** Um método ágil que tenho familiaridade é o Scrum, que consiste em sprints com duração de duas a quatro semanas. Dentro dessa metodologia, há papéis como Product Owner, Scrum Master e o time de desenvolvimento. Todas as tarefas são organizadas em um backlog de tarefas priorizadas e a cada sprint o time seleciona o que será feito. Dentro de cada sprint são realizadas as dailys, que são reuniões diárias para acompanhamento das demandas, além de reuniões de planejamento. 


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI/CD é a prática de integrar o código de forma automática e frequente, garantindo que o software esteja sempre funcionando e que os erros sejam identificados rapidamente. É um processo fundamental para garantir que as novas versões do software sejam disponibilizadas de forma mais rápida e confiável.
Algumas ferramentas que são utilizadas são o Jenkins, GitHub Actions, GitLab CI, Azure Devops e Travis CI.

12. Qual a diferença entre Docker e Containers.

**Resposta:** Container é um conceito, enquanto que o Docker é uma ferramenta que implementa esse conceito. Containers são ambinetes isolados que permitem executar aplicações e seus componentes com todas as dependências necessárias, garantindo portabilidade e consistência entre diferentes ambientes. Funcionam como mini-máquinas virtuais porém são mais leves. O Dockcer é uma das plataformas mais populares para criar, gerenciar e executar containers. Ele fornece comandos, APIs e ferramentas que facilitam a criação de imagens, gerenciamento de ciclo de vida dos containers e a distribuição dessas imagens em diferentes ambientes.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** A principal diferença é que Kubernetes é uma plataforma para orquestração de containers, com foco em automatizar a implantação, o gerenciamento e o escalonamento de aplicações em containers, enquanto que o OpenShift é uma plataforma de orquestração de containers baseada em Kubernetes, que adiciona uma série de recursos extras como uma interface web nativa, ferramentas de CI/CD integradas, controle de acesso mais robusto.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** As APIs permitem integração entre diferentes sistemas e plataformas, além de facilitar a comunicação e reutilização das funcionalidades. É mais fácil de escalar e possibilita o desenvolvimento de aplicações mobile, web e de terceiros usando os mesmos recursos. Uma desvantagem que a api traz é que pode aumentar a complexidade do sistema devido a necessidade de versionamento e documentação, além de trazer latência que pode afetar drásticamente o desempenho e qualquer mudança em uma API já existente pode impactar clientes diferentes. 
Quando escolhemos essa abordagem, é necessário garantir a segurança dos dados que essas APIs disponibilizam, trazer um versionamento para evitar quebra de compatibilidade, documentar as APIs para facilitar o uso, planejar limites de uso. 


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Conseguimos garantir um nível satisfatório seguindo as boas práticas usando HTTPS para proteger a comunicação e evitar interceptação de dados, implementando autenticação (como OAuth2, JWT) garantindo que apenas usuários autenticados possam acessar as informações que aquela api disponibiliza, validar todas as entradas recebidas para evitar ataques como SQL Injection, monitorar acessos e tentativas de acesso suspeitas. 


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Serve para facilitar a comunicação assíncrona entre diferentes sistemas, serviços ou componentes de uma aplicação. Permite que dados, comandos ou eventos sejam enviados e recebidos por meio de mensagens. Isso permite que difrentes partes da aplicação possam operar de forma independente, absorver picos de demanda e garantir a entrega de informações mesmo que algum serviço esteja temporariamente indisponível. Exemplos: RabbitMQ, Kafka, AWS SQS.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** É um padrão usado em arquitetura de microserviços para gerenciar transações que envolvem múltiplos serviços independentes. A SAGA divide a transação em uma sequência de pequenas transações locais, cada uma executada por um serviço diferente. Se todas as etapas forem concluídas com sucesso, a operação geral é considerada bem-sucedida, caso alguma etape falhe, a SAGA executa operações de compensação para desfazer as etapas anteriores, gaarantindo a consistência do sistema.

Existem duas formas de implementar a SAGA: Orquestrada, onde um serviço central coordena as etapas, dizendo a ada serviço o que fazer e quando executar as operações de compensação; Coreografada, onde não há um coordenador central, cada serviço publica eventos e reage a eventos de outros serviços, executando suas ações conforme necessário.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** GitOps com Kubernetes, ao meu ver, significa gerenciar e operar clusters e aplicações Kubernetes por meio de pull requests e versões no Git, promovendo automação, controle e segurança no clcio de vida da infraestrutura.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Um case de sucesso que participei ativamente foi a Replicação de dados em PostgreSQL. Era um desafio novo, foi a primeira migração de dados que participei e não tinha ninguém com experiência nisso dentro da empresa (foi a primeira migração da empresa também). O cenário exigia garantir a consistência dos dados em tempo real para sistemas diferentes, mantendo a performance, sem travar as tabelas ou afetar o tempo de resposta das aplicações. Estudei bastante sobre ferramentas ETL, mas encontrei a solução de forma nativa com a replicação lógica do Postgre. Li bastante a documentação e diversos artigos a fim de descobrir mais sobre e depois de um período de testes, decidi implementar a solução de forma efetiva. Modelei um fluxo, criei triggers de replicação que só eram acionadas a partir de dados vindo da réplica, transformando esses dados e inserindo nas tabelas alvo já modelados. O resultado dessa implementação foi que garantimos o uso simultâneo do sistema antigo e do novo e fomos passando os clientes para as novas aplicações sem perder nenhuma informação e sem nenhum downtime.
