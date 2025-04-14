# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário
# Cite 6 fatores do Twelve-Factor App e explique cada um deles.
- Resposta: Eu nunca havia falado sobre essa metodologia, então pesquisei a respeito e coloquei apenas os que já utilizei.

Ambiente de Dev = Prod - Manter os dois ambientes iguais ajuda a evitar bugs em produção que não ocorrem em desenvolvimento (famoso na minha máquina funciona). Mesmo banco, mesma estrutura. No primeiro bate papo com a Jessica comentei de um problema que tive por conta de data, em dev tudo ok, mas o ambiente de produção rodava em um fuso horário diferente, a solução foi definir explicitamente qual fuso horário eu queria.

Serviços externos como recursos anexáveis (Backing services)- realização a troca de informações com serviços externos por autenticação ou URL de forma que facilite a troca ou substituição com menor esforço possível. Em uma das soluções entregues pra Vale, todo o acesso pra comunicação com o serviço que gerenciava os dispositivos externos era feito através de url, dessa forma ao realizar testes eu criava um serviço básico pra troca de mensagens e nos testes era só colocar a url e porta correta.

Configurações armazenadas no Ambiente(Config) - ao invés de criar uma constante para cada valor único dentro do código fonte, centralizar esses valores nas variáveis de ambiente dessa forma ao realizar alguma alteração nos parâmetros, só é necessário realizar naquele ponto e não ao longo do código.

Codebase - todo o código fonte de uma aplicação deve ter como base uma mesma fonte, no gitflow gerenciamos as alterações criando branchs para realizar as alterações e posteriormente fazendo merge com a base.

Dependencies - a aplicação deve deixar clara todas as dependencias utilizadas, para que fique claro replicar o ambiente, em linguagens com o typescript ficam no package.json.

# Quais são as principais camadas no desenvolvimento de um software?
- Resposta: depende muito de qual estrutura de desenvolvimento está sendo usada, MVC, DDD.
Na Autoglass usávamos a DDD, dividindo o projeto em Apresentação, Aplicação, Domínio, Infra sendo que:
Apresentação - Controllers que recebiam e enviavam dados.
Aplicação - continha a lógica de distribuição das atividades para os respectivos serviços
Dominio - Continha a lógica do negócio (serviços) e as entidades.
Infra - Camada de conexão e manipulação do banco de dados ou serviços externos.

# Diferencie Arquitetura SOA X Arquitetura microserviços.
- Resposta: Na Soa os serviços são grandes e podem ser interdependentes, e se comunicam via barramento de serviços podendo utilizar protocolos complexos.
Na arquitetura de microserviços os serviços são bem pequenos e especialstas em um assunto específico, trabalhando independente dos demais serviços e a comunicação pode ser por mensageria, Http.

# Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.
- Resposta: Nunca utilizei, mas o objetivo é ter uma camada de controle adicional pra monitorar as demais API's. como gerenciamento de acesso por Token e etc.

# Qual a diferença entre uma Struct e uma Class?
- Resposta: Struct geralmente é utilizado para objetos imutáveis e pequenos, class são objetos de referência, onde pra cada objeto criado a partir de uma class ele aponta pro mesmo objeto permitindo que seja mutável e tenha qualquer tipo de construtor.

# Explique a grande diferença entre .NET e .NET CORE.
- Resposta: .Net(Framework) só roda no Windows e .Net Core é multiplataforma. O .Net Core a partir da versão 5 passou a ser chamada só de .Net

# Quais as principais diferenças entre REST e GRPC?
- Resposta: desconheço a GRPC. Mas o Rest trabalho com http e Json, tornando de fácil interpretação e fácil de testar, com o POSTMAN por exemplo

# Explique como funciona um gerenciamento de rotas de uma SPA.
- Resposta: é feito através de bibliotecas (Angular Router), através de uma URL padrão quando o usuário clica em um elemento, ele é redirecionado pra uma nova url, onde a página vai alterar o que está sendo exibido sem baixar um novo Html, buscando apenas os dados quando necessários nas Api's.

# Falando sobre DevOps, comente o que conhece sobre.
- Resposta: no meu entendimento o Devops é uma forma de facilitar o trabalho de entrega de um software para o usuário final, desde o momento que o desenvolvedor cria uma aplicação onde através de um ambiente preparado para pegar aquela aplicação realizar os testes necessários e aplicar ela em produção. Meio que automatizando processos repetitivos e bem definidos como  testes por exemplo

# Explique sobre um método agile.
- Resposta: SCRUM  - é uma forma de ajustar a rotina de desenvolvimento de forma a definir de forma bem clara atividades e responsabilidades, priorizar tarefas e identificar pontos de ajustes e melhorias no desenvolvimento.
no Scrum temos o backlog de tarefas, o planejamento da sprint (onde são priorizados as atividades a serem executadas), as Dailys pra auxiliar a encontrar gargalos e soluções, a review/retrospective que ajudam a revisar entregas e pontos de melhoria. Eu acredito que pode ser totalmente adaptado pra realizade da equipe, desde as cerimônias até o tempo de sprint e daily. 

# Comente sobre CI e CD e algumas ferramentas do dia a dia.
- Resposta: sei que CI/Cd é relacionado a entrega contínua e que uma das ferramentas para isso é o Jenkisn mas não tenho conhecimento na atividade, nunca utilizei, o mais próximo disso foi acompanhamento da esteira de deploy pelo Jenkins

# Qual a diferença entre Docker e Containers.
- Resposta: o Docker é um gerenciador de Containers, é uma ferramenta pra que implementa esse conceito. Já o Container é "mini" sistema operacional onde você pode instalar sua aplicação tendo apenas o que é necessário de modo a facilitar o gerenciamento, com criação e destruição com facilidade

# Qual a diferença entre Kubernetes e Openshift?
- Resposta: ainda estou estudando sobre Kubernets e Openshift não conheço

# Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?
- Resposta: vantagens: separar responsabilidades, facilitar reutilização de código e facilitar comunicação entre sistemas escritos diferente(ex desse último é uma api rest comunicar com a API do Serasa que é SOAP).
desvantagem: a única que consigo falar é que os erros precisam ser bem tratados, senão podem dificultar o entendimento no Front

# Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?
- Resposta: entre usuários eu entendo que através de uso de tokens como JWT e protocolo Https, e entre aplicações através de usuário/senha ou chave de segurança

# Para que serve uma arquitetura de mensagerias?
- Resposta: ainda vou estudar a respeito, mas entendo que serve pra facilitar o gerenciamento de comunicação entre aplicações de forma a não deixar que  múltiplas requisições gerem gargalos na operação.

# Explique a estratégia SAGA em arquitetura de microservice.
- Resposta: não conheço ainda

# Descreva o seu entendimento sobre GitOps utilizando Kubernetes.
- Resposta: não conheço ainda

# Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

- Resposta: Como comentado na primeira etapa da entrevista, tínhamos uma POC na Vale chamada de Safer Stack, que consistia num sistema de câmeras instalados num caminhão basculante fora de estrada que através da captura e tratamento das imagens via visão computacional fazia identificação de "cristas(monte de terra que indicava fim de uma via)" e enviava sinal de Crista, além da distância do caminhão até esse ponto de forma que deveria ser exibido num tablet dentro da cabine do caminhão a imagem em tempo real, a distância e a indicação se seria ou não uma crista. a comunicação com o servidor das câmeras era realizada via http. Quando assumi o projeto, foi me informado que a aplicação estava pronta e era só conectar o tablet com o server que tudo funcionava. Ao ir para o teste identificamos que havia um delay na imagem de 5 segundos o que tornava a atividade insegura, dessa forma pesquisando uma nova possibilidade foi utilizado o Web_View reduzindo o atraso para 1s, além da inclusão de um alarme sonoro quando a distância estava menor que a indicada pelo usuário. A Solução atendeu a área de negócio de forma que o projeto hoje está em processo de geração de patente.







