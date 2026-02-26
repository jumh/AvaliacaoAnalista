# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** 
Base de código: Utilizar algum repositório para armazenar e versionar os códigos, e apenas ter uma aplicação para cada base de código. 
Configuração: Configurações hardcode são más práticas, é melhor utilizar variáveis de ambiente para armazenar as configurações. 
Serviços de Apoio: O desenvolvimento da aplicação deve ser feito com baixo acoplamento a serviços como banco de dados ou mensageria por exemplo, para caso sejá necessário alguma substituição. 
Descartabilidade: Os processos devem ser descartáveis, eles devem iniciar e desligar rapidamente e sem impacto, e também devem estar preparados para falhas. 
Paridade Dev/Prod: A ideia desse fator é reduzir as diferenças entre esses ambientes em três aspectos: 
Temporal: O deploy de uma aplicação deve ocorrer de forma rápida; 
Pessoal: Os desenvolvedores e o pessoal que faz a gestão do deploy devem ser as mesmas ou próximas; 
Ferramentas: os ambientes devem ser idênticos para que não ocorra diferença de comportamento da aplicação; 
Processos Administrativos: Caso seja necessário realizar algum processo, como uma migração de banco de dados, é recomendado realizar em um ambiente idêntico, mesma versão, pacotes, configuração, etc, para que sejam minimizados os riscos.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** 
No geral, é dividido em IHM (interface), BLL (regras de negócio) E DAL (acesso e persistência de dados). Em apis costumo segregar ainda mais, dividindo a BLL em 2 camadas, separando assim quem conversa com a interface e quem conversa com o banco de dados. 


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** 
Arquitetura SOA é um método de desenvolvimento de software que usa componentes chamados de serviços para criar aplicações. 
Arquitetura de microserviços é uma evolução do estilo de arquitetura SOA, nele cada microserviço é um componente muito menor do que os serviços do SOA, e é especializado em apenas uma única tarefa. 
As diferenças ficam por conta da comunicação, onde nos microserviços mais normalmente é utilizado APIs RESTful. E também por conta da implantação, no SOA, caso um novo serviço seja adicionado ou algum seja alterado, será necessário reconstruir a aplicação inteira, já os microserviços são totalmente independentes.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
São ferramentas utilizadas para gerenciar, padronizar, documentar, monitorar e aumentar a segurança das apis.
As vantagens são claras, aumentando a segurança, estabelecendo padrões, melhorando a observabilidade e monitoramento.
As desvantagens ficam apenas por conta do custo, desempenho e complexidade que podem vir a aumentar.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** 
Enquanto a class é um tipo de referência, a struct é um tipo de valor, então por utilizar menos espaço de memória, a struct fica armazenada na stack e não na heap, tendo uma performance melhor. A struct pode ser utilizada quando precisamos armazenar valores primitivos para representações simples.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** 
O .net core é mais recente e possui menos bibliotecas, porém ele é cross-platform, funciona em outros sistemas operacionais além do windows.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** 
O GRPC é mais focado para performance e velocidade, então utiliza protobuf e o REST JSON. 
O REST também tem acoplamento fraco, então uma alteração na api não necessariamente precisa de uma alteração em quem a consome, já no GRPC, qualquer atualização vai exigir atualização tanto no servidor quando no cliente.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** 
O gerenciamento ocorre do lado do cliente, utilizando alguma biblioteca, o react por exemplo, utiliza o react router onde cada rota vai ser um componente react.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** 
Entendo sobre devops como uma metodologia que abrange todo o ciclo de vida de uma aplicação ou implementação, desde o desenvolvimento, até o deploy e a posterior monitoração.


10. Explique sobre um método agile.

**Resposta:** 
Vou falar sobre o Scrum, onde temos os seguintes termos: 
Product Backlog: é uma lista contendo as demandas; 
Sprint: a divisão dos períodos no Scrum, os ciclos; 
Sprint Backlog: a lista de demandas que será realizada dentro do Sprint atual; 
Daily Scrum: uma reunião rápida e diária, onde o time comenta o que foi feito no dia anterior, o que será realizado no próximo dia e se houve algum impedimento.
Scrum Master: a pessoa que atua como um facilitador para a equipe, ajudando em necessidades e nas práticas do Scrum; 
PO: a pessoa que define os itens que compôem o product backlog e os priorizas nas sprints plannings; 
Sprint Planning: a reunião envolvendo os participantes da equipe, junto com o PO e o Scrum Master, onde será definido o sprint backlog; 
Sprint Review: uma reunião para a equipe mostrar o que foi alcançado dentro da sprint que terminou; 


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** 
CI/CD é a integração e entrega contínua, tem muito a ver com DevOps, uma ferramenta que conheço e utilizo para implementação dessas práticas é o Jenkins, onde quando configurado, a partir de um commit, já são executados os testes, e se não houver erros, o sistema já realiza o build e o posterior deploy da aplicação no ambiente. Também é possível configurar e analisar diversos pontos da aplicação pelo Jenkins, como duração do deploy, váriaveis de ambiente, entre outros.


12. Qual a diferença entre Docker e Containers.

**Resposta:** 
Containers são pacotes contendo o código de uma aplicação, ou parte dele, junto de suas dependências, bibliotecas, e tudo que seja necessário para ele ser corretamente executado. 
Já Docker é uma plataforma que facilita a criação e a administração dos containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** 
O Openshift foi construído com base no Kubernetes e implementa algumas outras funcionalidades ao mesmo tempo qua facilita, sendo mais fácil para integrar com softwares.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** 
Vantagens: 
Possibilidade de utilizar o mesmo código em diversas interfaces, assim desacoplando as funcionalidades e diminuindo a duplicidade de código dentro das aplicações; 
Opção de utilizar linguagens e tecnologias diferentes; 
Melhor organização de código, podendo utilizar uma arquitetura específica para a API; 
Desvantagens: 
Maior complexidade de desenvolvimento; 
Possibilidade de fugir de um padrão conforme o número de APIs vai aumentando;


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** 
Com autenticação e tokens, limitação de chamadas, utilizando health check, e também utilizando algum api gateway ou management.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** 
Podemos utilizar mensageria quando queremos um baixo acoplamento entre os sistemas, tornando a comunicação assíncrona. Também é utilizado para integrar sistemas de diferentes linguagens. E principalmente para a aplicação que vai produzir a mensagem não precisar verificar se a aplicação que vai consumir está disponível no momento e também quando precisamos que sejam realizadas novas tentativas de consumo da mensagem caso ocorra alguma falha na primeira vez. 


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** 
Saga é uma arquitetura que utiliza um tipo de rollback, onde cada processo tem uma tarefa compensatória, e durante o fluxo, caso algum dos processos dos microserviços apresente alguma falha, as tarefas compensatórias desse e dos demais processos anteriores serão executadas assim revertendo suas respectivas alterações.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Gitops é uma abordagem onde se utilizam repositórios git para serem responsáveis por gerenciar toda a parte de infra da aplicação. Assim trazendo pra infra as vantagens que o código tem ao utlizar reposiótios git como confiabilidade, automação, velocidade, consistência e backups. Para utilizar com Kubernetes precisa usar alguma ferramenta como ArgoCD ou Flux pra sincronizar com o cluster.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Como case de sucesso posso citar um projeto que atuei no banco em que trabalho, onde refizemos um sistema responsável emitir notas fiscais em conjunto com um webservice da prefeitura.
O software tem funções como importação de planilhas, crud completo no banco de dados, chamada de webservices internos e externos, criação de arquivos, utilização de e-CNPJ incluindo assinatura de documentos e autenticação em apis da receita federal.
O sistema estava em uma linguagem um tanto quanto defasada, vb.net, e nós refizemos ele em c# utilizando .net framework, não foi utilizado .net moderno devido a ser um sistema de complexidade baixa/média que estava em um servidor antigo e usando bibliotecas mais antigas. 
Aproveitamos a criação do sistema novo pra fazer toda a parte da classe de testes que não existia ainda, com isso o projeto foi configurado corretamente no jenkins com o sonar, não deixando espaço para implementações futuras sem testes, já que o jenkins está configurado para barrar qualquer deploy que não contenha 80% de cobertura.
Também implementamos funções novas no sistema que agregaram muito para o cliente interno reduzindo tempo e falhas e assim aumentando o lucro, colocamos, por exemplo, um módulo que coleta os dados das notas geradas e cria arquivos referentes ao tributos PIS e COFINS que precisam ser enviados para a prefeitura mensalmente, antes o setor tinha que fazer todo o preenchimento de forma manual.
O sistema usou gitlab como repositório, jenkins como ferramenta de ci/cd, sybase e sql server como banco de dados.
A aplicação foi construída com base na clean architecture e seguindo fortemente os princípios SOLID. Também utilizamos o padrão de projeto Unit of Work.