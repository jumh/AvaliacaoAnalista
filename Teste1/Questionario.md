QUESTIONARIO

Cite 6 fatores do Twelve-Factor App e explique cada um deles.
Resposta:
1-Base de Codigo
Cada aplicação possui seu próprio repósitorio e se pode ter várias intancias dele.

2-Dependências
Deve-se declarar todas as dependências de forma explicita,
utilizando principalmente a ferramenta Nuget (no contexto .net) para que fiquem visível no arquivo .csproj 
e tambem na biblioteca Nuget.

3-Configurações
Configurações como CS, variaveis de ambiente ou dados sensíveis devem ficar fora do codigo,
se preciso em variaveis de ambiente para ser gerenciada em CI/CD.

4- Serviços de Apoio
Quaisquer serviços externos (como banco de dados) tem que ser tratado como um recurso que pode ser alterado facilmente,
no caso de banco de dados por exemplo, nada de CS em harded coded,
para que possa ser alterada facilmente dependendo do ambiente (com variaveis).

5-Build, Release e Run
Separar o processo nessas 3 etapas para evitar que mudanças no codigo possa quebrar algum ambiente em caso de deploy.
Em .net isso pode ser realizado com dotnet build e dotnet run por exemplo.

6-Concorrência
Use ferramentas como docker e kubernets para escalar o processo,
o .net utiliza o Kestrel para lidar com multiplas threads mas dependendo do nivel de requisições
e usuários ativos pode ser necessário escalar horizontalmente com alguma das ferramentas citadas.

Quais são as principais camadas no desenvolvimento de um software?
Resposta:
As principais camadas (se tratando de arquiiteturas populares como clean e screaming architeture) são:
Camada de apresentação:
É a primeira camada da aplicação no sentido de fora para dentro, onde a requisição externa chega,
geralmente se apresenta em classes de 'Controller'.
Camada de aplicação:
É o local onde define o 'core' do projeto, as regras de negócios e a parte lógica do processo,
geralmente se apresentando em classes de 'Services'.
Camada de Dominio:
É a camada que define os modelos e entidades da aplicação,
geralmente é possui dados que serão consumidos pelas outras camadas.

Diferencie Arquitetura SOA X Arquitetura microserviços.
Resposta:
Microserviços geralmente são mais independentes, geralmente com maior separação e apartando contextos ainda menores,
geralmente utilizam docker e kubernetes com mais frequencia.
SOA é uma separação interna dentro de uma mesma aplicação, 
onde é apartado a funcionalidade e responsabilidade de cada 'assunto' em serviços independentes que se comunicam entre si.

Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.
Resposta:
API Management é basicamente a parte que faz a intermediação entre dados externos (clientes, aplicações,
outros tipos de requisições) e a propria aplicação.
As principais vantangens podemos citar como:
Gerenciamento centralizado, todas os endpoints são centralizados, podendo configurar politicas de acesso,
rate limite, caching, auth entre outras configs de forma geral para todos endpoints.
Facilidade tambem pode ser considerado uma vantagem, haja vista que existe bibliotecas
e ferramentas que facilitam a utilização como swagger/openApi e é comumente utilizado.

Como desvantagens podemos citar:
A dependência de outras ferramentas, como Azure Api Management ou até mesmo o swagger como citado anteriormente.
Outra desvantagem que pode ser considerada é o nivel de 'complexidade' adcional a sua aplicação,
tendo que vista que não é algo realmente obrigátorio, então é bom ser feito uma análise para avaliar se vale a utilização.

Qual a diferença entre uma Struct e uma Class?
Resposta:
Dentre as principais diferenças podemos citar a Herança, que é comumente utilizado em classes e o struct não suporta,
o tipo de armazenamento em memória e o impacto que isso pode ter em alguns contextos, como em collections.

Explique a grande diferença entre .NET e .NET CORE.
Resposta:
A principal diferença é no aspecto 'plataforma' o .net é exclusivo para windows, 
o .net core é multiplataforma, podendo rodar em qualquer sistema operacional.

Quais as principais diferenças entre REST e GRPC?
Resposta:
REST é o padrão de comunicação mais utilizado no mundo, tem metodos bem claros e de nome auto-explicativo, 
já o GRPC é extramemente útil para comunicação entre sistemas por se tratar de uma comunicação binária direta 
porém exige um nivel de conhecimento técnico mais elevado 
e adciona um patamar de complexidade na aplicação que tem que ser levado em conta.

Explique como funciona um gerenciamento de rotas de uma SPA.
Resposta:
É realizado de forma fluída com definição de Rota/Roteador, navegação do cliente e carregamento de dados. 
Quando é acessado uma URL o roteador intercepta a requisição e decide qual componente exibir,
carregando somente os dados necessários.

Falando sobre DevOps, comente o que conhece sobre.
Resposta:
Conheço as principais etapas de CI/CD que é executadada durante uma pipeline antecedendo o deploy em ambiente.
Alem disso as partes referente gerenciamento e monitoramento de memoria, 
status e escalabilidade de pods através de docker e kubernets.

Explique sobre um método agile.
Resposta:
SCRUM, se trata da forma do qual uma equipe irá gerenciar suas demandas,
contando geralmente com 'sprints' de 2 semanas (podendo ser maior dependendo da complexidade do projeto), 
cerimônias diárias (dailys), cerimônias de novos projetos (Refinamentos) entre outras como Review e Retro.

Comente sobre CI e CD e algumas ferramentas do dia a dia.
Resposta:
CI se trata das etapas referente ao proprio projeto,
nesta etapa podem ser configuradas: execução de build, testes da aplicação, 
utilização de alguma ferramenta de monitoramento como sonarqube.
CD se trata das etapas referente ao próprio ambiente, 
nela geralmente é carregada as variáveis que serão utilizadas em cada ambiente
e também a geralmente ultima e mais importante etapa, que é o Deploy da aplicação.

Qual a diferença entre Docker e Containers.
Resposta:
Docker é a ferramenta do qual conseguimos criar pequenos 'ecosistemas' onde podemos gerenciar
praticamente qualquer software, Container é o nome dado ao 'espaço' reservado que podemos criar
e escalar dentro do docker.

Qual a diferença entre Kubernetes e Openshift?
Resposta:
Kubernets é o mais popular orquestrador de containers, é um serviço open-source do google. 
OpenShift seria um concorrente do kubernets da plataforma RedHat.

Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?
Resposta:
Escalabilidade, reutilização, facil integração com sistemas e flexbilidade para SPAs modernos.
Preucupação pode ser citada a segurança e o desempenho (latência).

Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?
Resposta:
A forma mais conhecida e popular é a utilização de JWT para autorização ao acessar os serviços

Para que serve uma arquitetura de mensagerias?
Resposta:
Mensagerias possuem muitas vantagens, mas as principais podemos citar a escalabilidade, 
a facil integração com ferramentas próprias e o desacoplamento da propria aplicação.

Explique a estratégia SAGA em arquitetura de microservice.
Resposta:
A estratégia Saga em microserviços é um padrão de design para gerenciar transações distribuídas,
garantindo consistência de dados em sistemas onde cada microserviço tem seu próprio banco de dados.
É interessante pois desacopla serviços, melhora a escalabilidade entre outros pontos relevantes.

Descreva o seu entendimento sobre GitOps utilizando Kubernetes.
Resposta:
É a forma de gerenciar a infraestrutura e aplicaçao utilizando GIT como principal fonte das regras,
pode se definir a configuração do cluster como pods, deployments entre outras configs em arquivos YAML
que ficam em um repositório próprio no git.

Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução
de algum problema, cite tecnologias e os desafios enfrentados.
Resposta:
Recentemente me chegou uma demanda de integração com a RD Station com uma certa urgência pois estava a algum tempo na responsabilidade
de outro desesenvolvedor, esta demanda se consistia na resolução de um problema que era referente a mensagens 'sumindo'
da fila do rabbitMQ, após muitos testes diagnostiquei que o enfileirador (producer) de fato estava deixando de enfileirar
algumas mensagens por nenhum motivo aparente.
Dado esse entendimento e a urgência do caso, realizei uma solução rápida e eficaz que foi a remoção do rabbitMQ
da aplicação e realizei um 'enfileiramento' utilizando banco de dados e status para cada etapa dos envios.
Desta forma consegui mapear todas as etapas de todas os envios através de querys no banco de dados,
o serviço no geral perdeu um pouco de velocidade de desempenho porém o problema foi sanado.