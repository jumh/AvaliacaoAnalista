# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
    Codebase: o app deve utilizar alguma ferramenta de versionamento de código, como Git. O app deve possuir apenas 1 base de código (codebase), mas pode possuir diversas implantações (deploys) derivadas dela. Tipicamente, um ambiente de produção e alguns ambientes de teste.

    Dev/Prod Parity: os ambientes de desenvolvimento e de produção devem ser mantidos o mais semelhantes possível. Deve-se evitar ao máximo o acúmulo de commits/merges em Dev que não foram aplicadas em Prod, além de também evitar utilizar ferramentas diferentes entre os ambientes.

    Dependencies: as dependências do app devem ser declaradas de forma explicita, através de um manifesto de declaração de dependências. Exemplos desses manifestos são package.json em projetos Node.js e .csproj em projetos .NET. Além disso, apps não podem depender de dependências externas ao projeto (não foram declaradas no manifesto mas que estão presentes de forma global no sistema)

    Config: valores constantes que diferem entre os ambientes, como credenciais e recursos do banco de dados, são considerados variáveis de configuração. Elas permitem alterar o comportamento de cada ambiente mesmo sem modificar o código. Por segurança, essas constantes não devem ser expostas diretamente no código.

    Processes: todos os processos do app devem ser stateless, ou seja, independentes e sem compartilhar informações entre si. Se algum dado precisa ser persistido, ele deve ser armazenado em um serviço externo que permita, como um banco de dados.

    Logs: o app não maneja ou registra os logs, apenas os envia para a saída padrão, onde ele será capturado e manejado pelo ambiente de execução. Tais logs podem ser manipulados de diversas formas, como simplemeste sendo printados no terminal, sendo arquivados ou até mesmo sendo enviados para sistemas de análise.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
    As principais camadas são Apresentação, Aplicação, Domínio/Negócio e Infraestrutura.

3. Diferencie Arquitetura SOA X Arquitetura microsserviços.

**Resposta:**
    Ambas as arquiteturas têm como objetivo dividir o sistema em serviços menores, mas utilizam abordagens diferentes para isso.

    SOA: serviços maiores em comparação aos microsserviços. Normalmente possui um Enterprise Service Bus (ESB) para a integração e comunicação entre esses serviços.

    Microsserviços: serviços bem menores e fundamentais, normalmente são stateless. Utilizam APIs ou mensageria para comunicação.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
    API Management centraliza o gerenciamento das APIs disponibilizadas por uma organização. Ele pode atuar como ponto de entrada para os consumidores das APIs, controlando autenticação, autorização, limites de utilização, monitoramento e roteamento. Entre algumas vantagens, pode-se citar centralização de segurança, monitoramento e padronização. No entanto, também pode gerar alguns problemas como aumento de latência e a criação de um ponto crítico na arquitetura.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
    Em C#, Class e Struct funcionam de forma semelhante internamente, comportando campos, métodos, construtores e modificadores de acesso. Já, externamente, eles são vistos de forma diferente pelo código. Class, assim como as Classes da maioria das linguagens, é tratada como referência. Já o Struct é tratado como valor. Isso implica que, em atribuições, um outro Struct com o mesmo valor é criado para a variável, assim como ocorre com os tipos primitivos. Outra diferença é que Struct não suporta herança, diferente de Class.
    De forma geral, Class é utilizada para representações mais complexas, enquanto Struct é utiliza para representações mais simples.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
    .NET CORE é o sucessor multiplataforma (Windows, Linux e macOS) de código aberto do antigo .NET Framework, que funcionava apenas em Windows e era de código fechado.
    Hoje em dia, .NET CORE é chamado apenas de .NET.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
    REST e gRPC são formas de comunicação utilizadas em API.
    REST é a mais comum, sendo utilizada em APIs públicas e sites. Utiliza principalmente HTTP e transporta dados por texto (em formatos JSON ou XML, por exemplo). Por esse motivo, também é mais facilmente debugável por um humano.
    gRPC é mais recente, sendo utilizado principalmente entre microsserviços e apps com alto fluxo. Utiliza HTTP2 e utiliza dados binários com Protocol Buffers. Por conta disso, geralmente é mais eficiente em relação ao REST.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
    O gerenciamento precisa acontecer tanto no backend quanto no frontend.
    No backend, as rotas "falsas" precisam ser mapeadas para o mesmo HTML da rota principal, permitindo que elas possam ser acessadas diretamente.
    No frontend, bibliotecas como React Router são utilizadas para gerenciar e modificar o HTML principal, também utilizando HistoryAPI para alterar a URL e controlar o histórico de navegação sem recarregar a página. Em caso de acesso direto a uma sub-rota, essas bibliotecas recebem o HTML principal e fazem as alterações correspondentes.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
    É um conjunto de práticas que busca aproximar as áreas de desenvolvimento e operações. Ele promove maior integração entre as equipes, automatização de processos, mais confiança nos resultados e um contínuo ciclo de feedback.

10. Explique sobre um método agile.

**Resposta:**
    No Scrum, o desenvolvimento é organizado em períodos curtos chamados Sprints, que normalmente duram de 1 a 4 semanas.

    No início de cada Sprint, são selecionados itens do Product Backlog para formar o Sprint Backlog, de acordo com as prioridades e a capacidade da equipe.

    Durante a Sprint, os desenvolvedores organizam entre si como o trabalho será realizado. Também ocorrem reuniões diárias rápidas (Daily) para acompanhar o progresso e identificar impedimentos.

    No final da Sprint, os resultados são apresentados e ocorre um feedback sobre os processos para identificar pontos de melhoria.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
    CI (Continuous Integration) é a prática de integrar alterações de código frequentemente, executando processos automatizados como build, testes e validações.

    CD pode significar Continuous Delivery ou Continuous Deployment. Continuous Delivery mantém o software sempre pronto para implantação, enquanto Continuous Deployment automatiza também a implantação em produção.

    Algumas ferramentas utilizadas para esses processos são GitHub Actions, GitLab CI/CD, Jenkins e Azure DevOps.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
    Container é uma forma de isolamento de processos que permite executar uma aplicação juntamente com suas dependências de maneira separada do restante do sistema.

    Docker é uma plataforma e conjunto de ferramentas utilizadas para criar, distribuir e executar containers.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
    Kubernetes é uma plataforma de código aberto de orquestração de containers. Ele gerencia recursos como containers, escalabilidade, disponibilidade, redes, configuração e atualização das aplicações.

    OpenShift é uma plataforma criada sobre o Kubernetes, disponibilizando seus recursos de orquestração junto de ferramentas adicionais para segurança, administração e desenvolvimento.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
    Vantagens:
    - Permite integração entre diferentes tecnologias
    - Reutilização de funcionalidades
    - Possibilidade de integração com terceiros
    - Separação entre frontend e backend
    - Maior escalabilidade

    Desvantagens:
    - Dependência de rede
    - Necessidade de controle de alterações
    - Necessidade de monitoramento
    - Maior exposição a ataques

    As principais preocupações são segurança, autenticação, autorização, versionamento, disponibilidade, latência, documentação, observabilidade, limites de consumo e tratamento adequado de falhas.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
    - Utilizar HTTPS/TLS
    - Implementar autenticação, como OAuth 2.0 e JWT
    - Limitar requisições do mesmo cliente em curto período de tempo
    - Gerenciamento de permissões
    - Validar informações do cliente antes de confiar nelas
    - Proteger credenciais
    - Se proteger de vulnerabilidades documentadas
    - Logs e monitoramento

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
    Arquitetura de mensageria permite comunicação assíncrona entre diferentes componentes ou serviços. Ao invés de aguardar uma resposta, um serviço publica uma mensagem em uma fila através de um sistema de mensageria, que posteriormente será consumida e processada por outro serviço.
    Tal abordagem permite processamento assíncrono e maior tolerância durante picos. Pode ser utilizada em situações com tarefas pesadas sem necessidade de processamento imediato.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
    A estratégia SAGA é utilizada para controlar operações distribuídas que envolvem diversos microsserviços, utilizando ações compensatórias caso alguma etapa falhe.

    Para exemplificar, considere 3 microsserviços A, B e C e uma tarefa que utilize eles nessa ordem A -> B -> C. Se durante a execução no microsserviço C ocorrer um erro, podem ser necessárias ações compensatórias em B e A para compensar as operações realizadas anteriormente.

    SAGA pode ser implementada de 2 formas diferentes:

    Coreografia: os serviços propagam entre si, por meio de eventos, a sequência de etapas e as ações compensatórias necessárias.

    Orquestração: existe um componente central responsável pela coordenação das etapas e das ações compensatórias.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
    GitOps é uma abordagem onde o Git é utilizado como fonte principal das configurações da aplicação e da infraestrutura.

    Em Kubernetes, arquivos de configuração podem ser armazenados em um repositório Git, representando o estado esperado do cluster. Ferramentas como Argo CD ou Flux comparam esse estado com o estado atual do Kubernetes e podem aplicar as alterações necessárias.

    Dessa forma, alterações na infraestrutura podem ser realizadas através de commits e Pull Requests, facilitando versionamento, auditoria e rollback.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
    Um dos principais projetos em que atuei foi em um ambiente dedicado do produto TOT - Tracking on Time, utilizado pelos terminais TES, TEAG e TEG.
    Esse ambiente possuía uma grande quantidade de solicitações acumuladas, com uma estimativa inicial de aproximadamente 1 ano para resolução do backlog.
    Atuei diretamente no desenvolvimento dessas demandas, ajudando a reduzir essa estimativa para cerca de 3 meses.
    Durante o projeto, trabalhei principalmente com TypeScript, Node.js, NestJS e PostgreSQL. Entre as atividades realizadas estavam o desenvolvimento e manutenção de APIs REST, implementação de regras de negócio, validações, criação de migrations, otimização de queries e criação de endpoints para integração com Power BI.
    Um dos principais desafios era trabalhar sobre um sistema já existente, com regras de negócio específicas para esse ambiente, garantindo que novas alterações não causassem regressões.
    Também foi necessário lidar com consultas mais complexas e preocupações com integridade e performance no banco de dados.
    Além disso, utilizei ferramentas como Jest para testes automatizados e Swagger/OpenAPI para documentação das APIs. Após a redução do backlog, passei a ser o principal responsável pelo ambiente dedicado, atuando na manutenção, correção de problemas e desenvolvimento de novas funcionalidades.