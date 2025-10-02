# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

 Codebase – Uma base de código com controle de versão (como gix por ex.), com N deploys, isso garante sabermos
            quem mudou o quê, e dá clareza nos processos de publicação nos ambientes.

Dependencies – A aplicação deve ter dependências explícitas e isoladas, por ex. no .NET, temos o .csproj com as versões
               de cada pacote especificadas de forma clara para a inicialização do projeto, e em aplicações front-end como o angular,
               temos o arquivo package-lock.json que faz o mesmo trabalho. 

Config – Configurações e/ou parâmetros devem ser separados do código (como por ex. variáveis de ambiente), isso
        evita a ocorrência de vazamento de credenciais de recursos em repositório, e evita conflito de segredos configurados 
        direto no código entre os ambientes.

Backing Services – Qualquer serviço/recurso externo deve ser tratado de forma acoplável, como um BD, uma fila, tópico, serviço de email,
                   (SMTP) e afins. Isso viabiliza, ou muitas vezes facilita, a troca dos provedores de serviço com uma simples alteração 
                   de variável de ambiente, sem a necessidade de um código que funciona unicamente para um provedor XPTO.

Build, Release, Run – Separar fases: compilação, release (config aplicada) e execução, basicamente define que 
                      um fluxo de CI/CD como azure pipelines por exemplo, deve ter etapas claras e de responsabilidade única 
                      (verificar compilação/testes unitários, buildar, gerar release, publicar no ambiente).

Processes – Aplicação executada como processos stateless, sem dependência de sessão local, ou seja, viabilizar que essa aplicação
            seja escalável horizontalmente (posso ter N pods/instâncias da mesma aplicação) sem prejudicar o funcionamento ou a experiência da aplicação, uma vez que independente da sessão que uma requisição ou processo executar, todos os dados necessários para o pleno funcionamento da mesma, estarão em recursos compartilhados, como em um Redis / BD por exemplo.

2. Quais são as principais camadas no desenvolvimento de um software?

Presentation - É a camada de interação com o usuário, que geralmente possui as controllers no caso de uma API, que pode ser exibida
               em uma interface visual com Swagger por exemplo, ou então uma aplicação UI (front-end em angular/react), que interage 
               diretamente com o usuário final do produto.

Application - Essa camada basicamente é responsável por orquestrar o processo, mas não pelo processo em si. Um exemplo no modelo 
              arquitetural de CQRS, são os handlers, que recebem a solicitação dos controllers, e apenas orquestram a interação
              com o core da aplicação, interagindo com interfaces de repositórios, dbcontexts, services, e afins.

Domain - Aqui nós temos o core da aplicação, onde declaramos todas as entidades (classes) num modelo de POO, bem como as entidades
         que representam tabelas de banco de dados. Além disso, o domain é responsável por administrar toda a regra de negócio da aplicação.

Infrastructure - Nessa camada, temos as configurações de comunicação com recursos externos como banco de dados SQL, Redis, Http Clients,
                 Injeções de dependência dos serviços, e outros recursos parecidos.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

Até onde me recordo, a arquitetura SOA é um modelo monolítico de produto. Geralmente é encontrada em produtos legado,
onde eu possuo aplicações feitas em .NET Framework por exemplo, com requisições SOAP, configuradas com WSDL.
Esses webservices em sua maioria possuem N contextos dentro da mesma aplicação, geralmente atendendo diversas partes diferentes da empresa, essas arquiteturas são muito simples a nível macro, mas complexas a nível micro.

Já a arquitetura de microserviços, busca reduzir ao máximo a complexidade a nível de código, tendo N aplicações pertencentes a um
mesmo processo, cada uma com sua responsabilidade. O que diminui muito a complexidade micro, mas aumenta a complexidade macro.
Ao trabalhar com microserviços, torna-se muito importante a criação de desenhos técnicos englobando todas as aplicações de um determinado
contexto, para facilitar o troubleshooting, e o onboarding de novos colaboradores da squad. Um exemplo é um processo onde tenho
uma API acionada por um squad XPTO, essa API busca um dado em um BD, envia-o para uma fila do RabbitMQ, que por sua vez é consumida por
uma 2° aplicação (worker) que realiza o enriquecimento dos dados, e envia o registro para uma 3° aplicação (SAP PI por ex.).


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

É basicamente o "porteiro" das APIs. Ele centraliza tudo que passa, controla acesso, faz rate limit, coloca métricas, segurança e documentação de APIs. Um exemplo prático que já utilizei, é o Sensedia, que funciona como um API Gateway para
todas as APIs da companhia, cada uma com sua própria configuração de ratelimit, timeout, redirecionamento, OAuth, e afins.

Vantagens: segurança centralizada, monitoramento, gestão de chaves.
Desvantagens: pode virar gargalo se mal configurado, custo em cloud e mais complexidade.

5. Qual a diferença entre uma Struct e uma Class?

 Struct é valor (copia quando passa pra frente, tipo int), mais leve, fica na stack. Por ex. int, DateTime, float.
 Já a classe é passada por referência, então se eu tenho um objeto de uma classe Carro com o campo cor = "Branco",
 e em seguida crio uma variável que recebe esse objeto, eu estou passando a referência para a variável, logo, eu tenho
 duas variáveis apontando para o mesmo objeto. Como consequência, se eu altero o valor de uma propriedade do objeto na variável 1,
 essa alteração também vai refletir na variável 2.

 Com o struct isso não ocorre, se eu tenho uma variável A que recebe um struct com uma propriedade "Idade" = 5, e em seguida
 faço com que uma variável B receba o valor da variável A, e altero o valor da propriedade "Idade" na variável B, isso não vai
 refletir na variável A, pois cada uma carrega o seu próprio valor, e não a referência (ponteiro) pra um objeto.


6. Explique a grande diferença entre .NET e .NET CORE.

O .NET antigo era "preso" ao Windows.Já o .NET Core veio como um rework multiplataforma (Windows, Linux, Mac), que é mais rápido, modular, e também open source. Hoje em dia tudo se unificou no .NET 5+.


7. Quais as principais diferenças entre REST e GRPC?

REST é um modelo de comunicação baseado em protocolo HTTP, muito usado em APIs atualmente, em sua maioria trafegando informações
em JSON.

Eu imagino que GRPC também seja um modelo de comunicação entre aplicações, porém não tenho conhecimento sobre o mesmo.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

Em um SPA, não há necessidade de recarga de página pra alteração de rotas, ou seja, você consegue navegar de /home para /login
por exemplo, sem que haja um refresh no navegador, uma vez que quem gerencia as rotas é o próprio JS, no caso do Angular, temos
o Angular Router, que define qual componente ou módulo será exibido na tela, de acordo com a rota. Logo, ao trocar de rota, o
que acontece por trás dos panos, é o fim do ciclo de vida de um componente X, e o início de um componente Y.


9. Falando sobre DevOps, comente o que conhece sobre.

Basicamente DevOps é uma cultura de desenvolvimento, que une a parte de desenvolvimento de software com a parte de operações, ou seja,
o que antes era gerenciado por pessoas diferentes, agora fica a cargo de uma única pessoa. O mesmo indivíduo que desenvolve a aplicação,
fica responsável pelo processo de entrega dessa aplicação nos ambientes, através de fluxos de CI/CD (continuous integration, continuous delivery). Possibilitando inclusive automações como, ao finalizar um Pull Request, a pipeline automaticamente executar o build e 
disponibilizar o novo código em ambiente de testes / homologação.


10. Explique sobre um método agile.

Um dos métodos que mais trabalhei foi com o Scrum, onde você tem o modelo de sprints (geralmente de 2 semanas), e 
antes de cada sprint, existem N ritos que compõem cada etapa do processo: A planning, onde o time se junta e define 
quais serão as demandas atacadas na sprint que irá se iniciar, quem irá executar o que, quais tarefas o time consegue entregar dentro
daquele período, define o nível de complexidade de tarefas, e afins. Temos também o rito da daily, que como o próprio nome diz, é um rito
diário que serve basicamente pro time alinhar o que foi feito no dia anterior, se há impedimentos, dificuldades, ou pontos de atenção.
E também outros ritos como a retrospectiva/ review, onde o time busca entender pontos positivos e negativos da sprint que terminou, e o que pode melhorar para a próxima sprint. Lembrando que nada disso é escrito em pedra, já trabalhei com várias variações do scrum, em algumas não haviam ritos como retrospectivas, sprints tinham duração maior, menor, e por aí vai.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

CI (Continuous Integration): cada commit é testado e integrado de forma automática, por ex.:
executa o build e testes unitários. Um exemplo de uso é quando um pull request é realizado, e este só pode ser completado 
quando a pipeline consegue buildar e executar os testes unitários com sucesso.

CD (Continuous Delivery/Deployment): Essa é a etapa de entrega do novo código nos ambientes, responsável por disponibilizar
as features/hotfixes nos ambientes de homologação e produção.

Na azure pipelines, por exemplo, é possível configurar através de arquivos .yml, vários fluxos diferentes de validação,
montando uma esteira 100% automatizada com stages de build, execução de testes unitários, publicação em homologação, publicação em produção, stage de rollback caso necessário, configuração de aprovações necessárias antes da execução de cada stage, e afins.
Existem também outras plataformas para construir um fluxo de CI/CD como o github actions, Harness, Jenkins, mas minha atuação sempre
foi com Azure Pipelines.


12. Qual a diferença entre Docker e Containers.

O Docker é uma ferramenta que serve para criar e gerenciar os containers.
Já o Container em si, é o conceito de ambiente isolado, leve, empacotado com dependências. Docker é só um provedor.


13. Qual a diferença entre Kubernetes e Openshift?

Kubernetes é um orquestrador de containers (também conhecido como k8s). 
Imagino que o OpenShift seja um outro orquestrador, porém não tenho conhecimento sobre.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

Vantagens: É essencial para integrar sistemas, possui escalabilidade, procotolo de comunicação bem definido,
possibilita o versionamento dos endpoints, e viabiliza a criação de documentações interativas como o Swagger.
Retorno padronizado em status codes, facilitando a compreensão global dos códigos (200,201,202,400,401,500,504,...) 
Permitindo uma comunicação segura entre aplicações, se bem estruturada com JWT, OAuth, etc.

Desvantagens: latência de rede pode ser um ponto de preocupação dependendo da volumetria / rate de chamadas
(em alguns casos, uma comunicação via websocket funciona melhor que N requisições HTTP), 
é necessário sempre ter o máximo cuidado com a retrocompatibilidade, evitando quebras de contrato com sistemas que já consomem a API em ambientes produtivos (alteração de Requests / Responses mal comunicadas podem impactar N consumidores), segurança extra necessária.
Preocupações: autenticação/autorização, versionamento, limitar requisições, não expor dados sensíveis.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

    Garantir uma autenticação robusta na configuração da API, com ferramentas como JWT, OAuth, API_KEY configurada
    como variável de ambiente. Configurar um api gateway como o Sensedia, que permite acessarmos o trace (lastro)
    de cada chamada, implementar rate limit para evitar sobrecargas na API. Configuração de CORS quando aplicável, 
    que permite construir políticas de validação de origem (url de quem consome a API), cabeçalho da requisição, e afins.
    Evitar o uso de DataAnnotations como [AllowAnonymous] em APIs .NET, que podem acabar expondo endpoints críticos sem
    exigir nenhum tipo de autenticação. E implementar Logs acoplados à ferramentas de observabilidade como o Datadog, que 
    permitem a criação de métricas e alertas baseados nos recursos da API, status codes, etc.

16. Para que serve uma arquitetura de mensagerias?

É o esquema de usar fila (RabbitMQ, Kafka, Azure Service Bus) pra os serviços conversarem sem depender de tempo real.
Exemplo: ao cadastrar um usuário, em vez de mandar e-mail de forma síncrona, você manda uma mensagem pra fila, outro serviço lê e dispara o e-mail. Assim você desacopla processos e evita travar o fluxo. Isso também é importante para processos que começam na UI (com interação do usuário) e são demorados, como a emissão de uma nota fiscal, por exemplo, para você não "segurar" o usuário com um loader demorado, você encaminha a solicitação do usuário para uma fila, e notifica-o posteriomente via push notification, email, whatsapp, ou qualquer outra plataforma de contato, de que o processo já foi finalizado e está disponível para consulta.

A arquitetura de mensageria também é muito utilizada para processos de alta volumetria abrupta, como processos de fechamento contábil, por exemplo, uma vez que o modelo de mensageria lida muito bem com grandes volumes, já que os consumidores não são sobrecarregados, e consomem de acordo com a sua capacidade de processamento.


17. Explique a estratégia SAGA em arquitetura de microservice.

Não conheço a estratégia SAGA.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

Não conheço na prática, mas na teoria, toda configuração de infra fica obrigatoriamente estruturado em manifests ou yamls, logo,
qualquer alteração desses códigos / arquivos, é refletida de forma automática na configuração do ambiente, além de impedir alterações manuais. A infra sempre vai seguir apenas o que está nos arquivos, como escalonamento de pods, configurações de memória e CPU, e etc.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

Fui o responsável por arquitetar e desenvolver o produto INT na Localiza &Co,
que realiza o cálculo de laudos para a frota de ~600k veículos da Localiza &Co, gerando abatimento fiscal de R$ 600 milhões/ano (cerca de R$ 50 milhões/mês). Esse produto possuía 3 aplicações (API, Worker, UI).

O usuário interagia com uma UI feita em angular 19 no modelo de SPA, importando uma planilha csv pré-formatada (a própria aplicação front-end disponibilizava a template que deveria ser usada), preenchida com a frota de veículos que o usuário desejava calcular.

Após importar, a aplicação front-end fazia uma validação prévia das linhas do arquivo, e depois abria uma conexão web-socket com a API (feita em .NET 7), e começava a receber os registros
da planilha via streaming. Enquanto esse processo acontecia (levava cerca de 3-5 minutos) o usuário podia ver em tempo real a progressão
com um loader animado em formato de carro em movimento, com um contador / total de registros processados.

a API gerava um registro em uma base AzureSQL (1 registro por solicitação de cálculo) e pegava os registros (cada linha da planilha representava um carro da frota) e os enviava para uma fila RabbitMQ.

feito isso, o usuário recebia a mensagem de que a solicitação foi recebida e o cálculo estava em execução, havendo uma tela para o mesmo
acompanhar o andamento do processo.

A aplicação Worker, também feita em .NET 7, configurada para se conectar com o RabbitMQ via MassTransit, consumia as mensagens de forma unitária, e realizava o cálculo da depreciação de cada veículo baseado nos padrões INT (um órgão reconhecido nacionamente que emite 
um laudo baseado em cálculo próprio, para abatimento de impostos).

Ao calcular cada veículo, o resultado do cálculo era armazenado na base AzureSQL, bem como o lastro para viabilizar a auditoria (de como o cálculo foi feito e os valores usados).

Ao processar todos os veículos, o worker atualizava o status da solicitação de cálculo, e o usuário conseguia obter o relatório resultado na UI através de uma nova conexão websocket, que obtinha todos os resultados do cálculo e gerava uma planilha como output em tempo de execução.

A aplicação UI também contava com uma gestão de acessos através do Azure AD (active directory) onde configurávamos quem teria acesso (user) e o nível de acesso na aplicação (role).

Esse produto foi entregue dentro do período de 3 meses de desenvolvimento, e garantiu um abatimento de impostos de R$ 600 milhões no primeiro ano de execução.

Um dos desafios enfrentados no projeto, foi lidar com o o volume de processamento no output do cálculo, uma vez que cada linha (carro) gerava 12 linhas como output (cada linha representando a depreciação mensal daquele veículo XPTO).

Pra garantir o processamento no tempo requisitado pela área de negócio (o cálculo precisava iniciar e terminar dentro de no máximo 20 minutos), precisamos implementar práticas como paralelismo, uso de indexes no banco para reduzir ao máximo o uso de DTU, escalonamento automático de pods, garantindo que tivéssemos um processo rápido, sem problemas com condições de corrida e ao mesmo tempo sem ofender a base de dados com múltiplas conexões e queries simultâneas.

Para garantir a integridade da solução, executamos também diversos testes de carga simulando dados esperados no ambiente produtivo, para ter certeza de que a infraestrutura das aplicações e da base de dados estava pronta para suportar a demanda necessária.

-------------------

Também fui responsável pelo desenvolvimento do produto PaymentHub da ASC Solutions, processando milhares de transações mensais via Pix, cartão, boleto e Bolepix, com seleção dinâmica da adquirente de menor taxa em tempo real.

Uma API desenvolvida em .NET 6 com uma aplicação backoffice (Angular ~16) estruturada para receber solicitações de transação de outros produtos internos, com uso de Redis como banco de cache, AzureSQL como banco relacional, Azure Service Bus como serviços de mensageria
para processamentos assíncronos, Azure Pipelines para o CI/CD.

A aplicação possuía integração com grandes adquirentes como Cielo, Pagseguro, Inter, Aarin, com algumas delas requisitando configurações
específicas de SSL para handshake em cada requisição. A aplicação também possuia integração com datadog para monitoramento e acompanhamento de lastros de cada transação, facilitando o apoio da equipe de N2, além do próprio backoffice que possuia diversas features como estorno, saque, reprocessamento, e lastro das transações.

