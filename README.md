# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Codebase: A aplicação tem que ter uma única base de código, que geralmente é um repositório Git. Pode ter vários ambientes como o de desenvolvimento, homologação e produção, todos eles utilizando o mesmo códgio. O que varia entre eles é a configuração.
Dependencies: A aplicação precisa declarar de forma explícita todas as bibliotecas que está utilizando, e não depender de nada que esteja global ou fora do seu controle no ambiente. Geralmente essas configurações são feitas em arquivos específicos, no .NET faz no .csproj e no Node faz no package.json.
Config: Tudo que for configuração e variar nos ambientes (como string de conexão ou chaves de API), tem que estar fora do código e ser injetadas por variáveis de ambiente. No Angular geralmente utiliza um environment.ts que separa por ambiente.
Backing Services: Qualquer serviço que a aplicação for usar (como banco, fila de mensagem ou e-mail) deve ser considerado um serviço externo que pode ser trocado de forma fácil, sem impactar o código principal. Ou seja, se um dia eu precisar trocar o RabbitMQ local pelo Azure Service Bus, eu devo apenas criar uma configuração nova e não reescrever o código.
Processes: A aplicação dever ser stateless, onde não deve guardar estado em memória local entre as requisições. Tudo que for estado precisa estar em um banco de dados, cache ou serviço externo. Tem cenários em que é bom utilizar o Redis caso precise manter um estado temporariamente.
Logs: A aplicação deve gerar logs simples e contínuos para a saída padrão. O tratamento, armazenamento e análise desses logs podem ser feitos por ferramentas como New Relic e Datadog (tem dashboards prontos para utilizar, minimizando a quantidade de configuração). Já utilizei no trabalho o Serilog que permite configurar múltiplos sinks (destinos dos logs), realizei configurações no console e arquivos locais.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Camada de Apresentação (Presentation): É a interface com o usuário. Pode ser uma aplicação Angular ou um aplicativo mobile. Exibe dados ao usuário e envia requisições ao backend.
Camada de Aplicação (Application): É o orquestrador da aplicação. É onde comando os fluxos de uso, não tem regra de negócio complexa, mas sabe quando e a ordem em que as coisas devem acontecer.
Camada de Domínio (Domain): É o coração da aplicação. Tem toda a regra de negócio, com entidades, interfaces e validadores. A Domain não depende de infraestrutura, até pode ser testada de forma isolada.
Camada de Infraestrutura (Infrastructure): Conecta a aplicação ao mundo externo. Faz a implementação dos contratos definidos no domínio como acesso ao banco (utilizando Entity Framework e Dapper), mensageria, storage e APIs externas.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
A arquitetura SOA (Service-Oriented Architecture) é um pouco mais antigo, que divide o sistema em serviços reutilizáveis que se comunicam geralmente por um barramento (ESB – Enterprise Service Bus). Ele funciona bem em ambientes corporativos grandes (integração entre sistemas legados), mas pode virar um gargalo se for mal utilizado.
A arquitetura microserviços é mais moderna, cada serviço é bem independente, podendo ter o seu próprio banco, ser versionado, implantado e escalado separado dos outros. A comunicação geralmente é via HTTP ou mensageria (como RabbitMQ), traz mais flexibilidade e autonomia pros times.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O objetivo do API Management geralmente é organizar, proteger e facilitar o consumo das APIs. Funciona como uma porta de entrada pras requisições, controlando os acessos, aplicando regras de segurança, limites de uso e cache também.
Vantagens: Ter uma segurança robusta, com autenticação, autorização e até proteção contra ataques. Facilita o uso de ferramentas de analytics e monitoramento.
Desvantagens: Pode ocorrer latência entre o cliente e o serviço final, até mesmo a queda do serviço em alguns casos. E as ferramentas de API Management tem um custo alto.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct é um tipo de valor, quando você passa uma struct para uma método como parâmetro, ela é copiada e as alterações não afetam o original (por esse motivo é mais leve). Class é um tipo de referência, se mudar alguma propriedade altera no objeto original também.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
O .NET Core é uma evolução do .NET (que também é conhecido como .NET Framework). O .NET Framework roda só no windows, enquanto o .NET Core roda em todos os sistemas operacionais. Hoje em dia é mais natural usar o .NET Core por ser mais leve, performático e em constante atualização (diferente do .NET Framework que está basicamente em modo de manutenção).

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST é baseado em HTTP (GET, POST, PUT, DELETE) e transporta os dados geralmente em formato JSON. O gRPC usa o HTTP/2 e troca mensagens em formato binário usando Protocol Buffers (o que faz ser mais performático).

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Em uma SPA utilizada no Angular, o controle de navegação é feito tudo no front-end. Ao invés do servidor carregar uma página nova a cada clique, o HTML base é carregado uma vez só e deixa pro Angular gerenciar as rotas no client-side. O que muda mesmo é o que está sendo renderizado na tela, sem ter o reload da página. Deixa mais leve a navegação e melhora a experiência pro usuário.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
O DevOps faz um integração entre o desenvolvimento e operações de TI. Fica responsável pelas automações com CI/CD, a parte da infraestrutura, monitoramento, tudo isso agrega para a melhoria do ciclo de entrega. No trabalho eu sempre verificava as pipelines no Azure DevOps quando o meu Pull Request era aprovado, assim eu avisava para os QAs que a demanda já estava disponível no ambiente para teste.

10. Explique sobre um método agile.

**Resposta:**
Eu utilizo muito o Scrum. Ele organiza o trabalho em sprints (geralmente de 2 semanas, depende muito da estratégia do time), é formado por  Product Owner, Scrum Master e o time de desenvolvimento. Tem reuniões como planning (planejamento das demandas que irão entrar na sprint), daily (momento em que o time fala das demandas que está atuando, geralmente leva no máximo 15 minutos), retrospectiva (reunião no final de cada sprint para falar sobre o que foi bom, o que dá para melhorar e as atitudes que podem manter). A ideia é entregar as demandas mapeadas no final de cada sprint.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Integração Contínua) é o processo de validar o código automaticamente toda vez que um desenvolvedor faz um push e o Pull Request da demanda é aprovado. Já o CD (Entrega Contínua ou Deploy Contínuo) fica encarregado de subir a aplicação no ambiente (geralmente em homologação ou produção) de forma automática. Quando trabalhei no Senac, eu monitorava as pipelines para garantir que os testes automatizados, a verificação do LINT e o build tinham passsado com sucesso.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker é uma ferramenta para criar, gerenciar e rodar containers. Os containers são uma forma de "empacotar" uma aplicação com todas as configurações necessárias e suas dependências para rodar de forma correta. É como se fosse uma máquina virtual, só que bem mais leve.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é uma plataforma responsável por orquestrar os containers, ajudando no gerenciamento de cada container, garantindo que as aplicações fiquem sempre disponíveis e fáceis de manter. Ainda não tive a oportunidade de utilizar no trabalho, meu conhecimento está a nível de estudo/curso.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
APIs facilitam a parte de integração entre sistemas, ajudam a fazer com que aplicações conversem entre si de forma padronizada e segura. Um exemplo seria o frontend consumir uma API para buscar dados do backend sem precisar saber como tudo é implementado por atrás. A desvantagem estaria em um controle de versão e segurança (como a autenticação) mal administrado, o que pode apresentar falhas/erros. Outro ponto é a documentação, uma API mal documentada vira um problema pra quem consome.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Utilizar HTTPs sempre que possível para garantir segurança, autenticação com tokens(como o JWT), limitar o acesso com regras/permissões. É sempre bom esconder dados sensíveis e expor o mínimo possível e manter o versionamento da API para evitar brechas nas mudanças que ocorrer.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
A arquitetura de mensageria ajuda na comunicação, de forma assíncrona, entre sistemas ou microsserviços. Em vez de um sistema depender da resposta imediata de outro, usa um broker de mensagens (utilizei o RabbitMQ) pra colocar essas mensagens em uma fila e deixar o consumidor processar quando puder.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
SAGA é uma forma de coordenar as transações nos microserviços, a ideia é quebrar uma transação grande em várias menores. Existe a orquestrada que tem um serviço central controlando o fluxo e a coreografada é quando cada serviço sabe quando acionar o próximo.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
O GitOps é modelo de infraestrutura como código, ele usa o Git como fonte única da verdade.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Na Minsait, como desenvolvedor frontend, participei da criação de novas telas, como a da home e do fluxo de reacomodação de voo. Separei os componentes em smart (lidar mais com dados e interações) e dumb components (parte mais visual), também isolei as regras de negócio em services reutilizáveis, o que facilitou futuras alterações sem quebrar funcionalidades. Implementei as rotas com Guards e Resolvers, garantindo que o componente fosse carregado com todos os dados prontos. Melhorei a responsividade das telas (tablet e mobile) usando media queries, Flexbox e CSS Grid Layout. Tudo isso ajudou a melhorar o NPS da aplicação (estava negativa e ficou positiva)

No Senac, atuei como desenvolvedor backend no sistema de produção responsável pela geração de relatórios de alunos, matrículas e cursos, separados por departamento regional. Ajudei a otimizar as consultas, analisei os gargalos com o SQL Profiler, fiz ajustes pontuais nas procedures mais lentas e apliquei indexação estratégica nas tabelas, o que reduziu bastante o tempo de resposta em relatórios mais pesados. Implementei um fluxo assíncrono usando o RabbitMQ, onde cada solicitação de relatório era enviada como uma mensagem. Usei o Direct Exchange para separar por tipo de relatório, deixando mais organizado as rounting key. Tudo isso ajudou na performane do sistema.