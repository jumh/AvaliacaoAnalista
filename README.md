# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
1 Codebase: Temos um unico repositório de código por aplicão
2 Dependencias: As dependencias ficam explicitamente declaradas, sem depender de pacotes instalados no sistema como no requirements do django ou csproj no C#
3 Configurações: As configurações como variáveis (base de dados, url ou chaves de api's) ficam fora do código fonte, não ficam hardcode mas em um env separado por exemplo, que pode ser configurado no ambiente cloud também
4 Serviços de apoio: são serviços externos (banco de dados, fila, cache) devem ser tratados como recursos anexados, facilmente substituiveis 
5 Build, Release e Run: Separar as etapas de construção, lançamento e execução da aplicação garantido o controle de versões e reprodução da mesma
6 Processos: A aplicação deve ser executada como um ou mais processos sem estado, permitindo fácil escalabilidade

2. Quais são as principais camadas no desenvolvimento de um software?

Resposta: 2 - Como principais camadas temos
Views: camadas de apresentação 
Bussines ou Services: Camadas que compoe a lógica da aplicação
Data ou Repository: Camadas de acesso a dados 
Claro se olharmos para uma aplicação com arquitetura simples e com a apresentação sendo renderizada pelo backend
No caso de uma api eu substituiria a view por controllers que devolvam json ou o tipo de dados solicitados


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA: É uma arquitetura orientada a serviços onde o sistema é dividido em serviços maiores, cada um com sua função específica — por exemplo, serviço de relatórios, cadastro de clientes ou processamento de pagamentos.
Diferente dos microserviços, na SOA os serviços são mais amplos e integrados, podendo ser reutilizados por outros sistemas.
A comunicação entre os módulos, que normalmente representam partes do negócio, é feita por meio de um barramento central (ESB), usando protocolos como HTTP e XML — na prática, é comum o uso de SOAP.

Microserviços: Nessa abordagem, seguimos a mesma ideia de separação de responsabilidades, mas com serviços menores, independentes e mais leves.
A comunicação costuma ser feita via REST ou mensageria, o que torna o sistema mais eficiente e desacoplado.
Uma vantagem importante é que, caso um serviço fique offline, os demais continuam funcionando normalmente, aumentando a resiliência e a escalabilidade do sistema.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta** 
Objetivo: API Management ou do inglêes gerenciamento de API é basicamente gerenciar os recursos de uma ou mais API's, como uma 
api muitas vezes tem  vários recursos como autenticação e autorização, logs de monitoramento ou mesmo healthchecks, limitador de requests para evitar abuso de requests (inclusive e uma boa pratica de segurança para evitar DDOS) documentação então precisamos de um ponto central de gerenciamento, isso temos em uma api e como temos um sistema de microserviços que precisamos gerenciar mais de uma api

Vantagens: 
Gereciamento centralizado da(s) API(s) 
segurança aprimorada 
monitoramento como mencionado acima 
podemos ter também algumas versões da mesma api, algo que não mencionei na descrição acima.

Desvantagens: 
podemos ter um custo mais elevado 
pois teremos mais um recurso sendo utilizado 
com certeza existe uma complexidade inicial para o desenvolvimento e precisaremos de uma ferramente para o gerenciamento que pode exigir um aprendizado inicial e mais a frente dependencias 


**Resposta:**


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct: é um objeto que pode parecer com uma classe onde podemos definir as propriedades e comportamento, porém a comunicação com objeto acaba sendo diferente no struct temos uma comunicação mais, o passado diretamente o valor e não a referencia do valor e o struct não suporta herança então seu uso acaba sendo indicado para dados mais simples ou imutáveis do código

Class
na classe podemos criar propriedades e comportamento, porém, diferente do struct é passado o valor por referencia, a classe é ideal para objetos complexos pois podemos usar herança e polimorfismo.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET é a versão mais antiga ou .NET framework, criada para rodar em windows e mais comumente usada em aplicações  como ASPNET.Webforms. 
.NET Core: este já é opensource, roda em linux, macos e windows tem uma performance melhor já se adequando a práticas de desenvolvimento mais atuais.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST: utiliza o protocolo HTTP 1.1 comunica-se por JSON (mais comum) e XML (menos comum)  é mais simples de ler e entender os dados
a comunicação REST ocorre quando o cliente solicita um pedido ao servidor e ele response e o REST é mais lento pois o JSON/XML acaba sendo um pouco maior

gRPC: mais rapido e performatico, usa menos banda e utiliza protocolo HTTP/2 ele também pode abrir várias chamadas no mesmo canal diferente do padrão REST e o gRPC suporta 

4 modos
1 unary (semelhante ao rest)
2 Server streaming
3 Cliente streaming
4 Bidirectional streaming (melhor quando usamos microserviços)

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Em uma SPA (Single Page Application) existe apenas uma única página HTML. Quando o usuário acessa uma rota, o gerenciador de rotas intercepta essa navegação, impede o recarregamento da página e renderiza dinamicamente apenas o componente associado àquela URL, utilizando a History API para atualizar o endereço no navegador.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Bom, eu entendo DevOps como uma cultura que une desenvolvimento e operações para tornar o processo de entrega mais rápido, automatizado e confiável.
A ideia é que o time de dev já pense em infraestrutura, integração contínua (CI) e entrega contínua (CD) desde o início do projeto.

Por exemplo, usando Docker conseguimos padronizar o ambiente de desenvolvimento e de produção, evitando incompatibilidades.
Com pipelines em ferramentas como Azure DevOps, GitHub Actions ou Jenkins, o código pode ser testado, versionado e implantado automaticamente — primeiro em ambiente de homologação e, se aprovado, em produção.

Isso permite que novas features cheguem ao cliente em minutos, com menor risco de erro e maior feedback do usuário final.




10. Explique sobre um método agile.

**Resposta:**
Metodologia agil é uma forma de gerenciar projetos de software com foco em entregas rápidas e contínuas por exemplo, no scrum, o projeto é dividido em sprints, que são ciclos curtos (geralmente de 1 a 2 semanas), onde o time planeja, desenvolve, testa e entrega uma parte funcional do sistema.
Ao final de cada sprint há uma revisão com o time e o cliente, permitindo feedback rápido e melhoria contínua.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
Bom aqui vou comentar o que usamos atualmente no trabalho, como utilizamos o GCP aqui é usado o Cloud Build, ele é usado para efetuar o build da aplicação e o Cloud Deploy que é usado para automatizar e organizar o processo de entrega, mas estamos migrando para Cloud run pois permite o deploy a parti de uma imagem docker além de que por ser custo sob demanda acaba por diminuir o custo e nós devs focamos mais no código que na infraestrutura. 

Também trabalhei com azure no projeto documental e lá usamos o 
Azure Repos para controlar as versões
Azure pipelines para testes e build
Azure Artifacts para pacotes e dependencias 


12. Qual a diferença entre Docker e Containers.

**Resposta:**
O Docker é a ferramenta usada para criar, gerenciar e executar containers.
Ele permite isolar aplicações do sistema operacional local, tornando-as mais leves, portáteis e sem problemas de compatibilidade entre ambientes.

Já o container é a instância da aplicação em execução, que contém tudo o que ela precisa — código, dependências e configurações — rodando de forma independente e isolada do restante do sistema.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é um orquestrador de contêineres, uma plataforma open source e flexível, mas que exige mais configuração manual. Já o OpenShift é uma distribuição corporativa do Kubernetes, com recursos adicionais de segurança, um console web completo e suporte empresarial — ou seja, o OpenShift é o Kubernetes pronto para empresas.



14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
As APIs trazem várias vantagens. Por serem uma abordagem mais moderna, permitem reaproveitamento de código e uma separação clara de responsabilidades, como camada de dados, negócios e apresentação.
Também possibilitam expor endpoints para que outras aplicações consumam dados ou funcionalidades, o que favorece a integração e a escalabilidade dos sistemas.

Por outro lado, uma API precisa ser bem projetada para evitar riscos de segurança, falhas de autenticação e baixa performance em consultas.
É essencial ter cuidado com o retorno dos dados (para não expor informações sensíveis) e também com o que é enviado para a API.
Por exemplo, um upload sem validação de tamanho pode causar sobrecarga no servidor e até uma indisponibilidade (ataque DoS).



15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Para garantir um nível de segurança adequado no uso de API's, podemos aplicar boas práticas em todas as etapas do desenvolvimento
Desde autenticação a controle do que é exposto para o usuário

API deve ter autenticação, e autorização (OAuth2, JWT ou API Keys) e usar HTTPS para criptografar o trafego
Validar a entrada de dados e sanitizar os dados para evitar ataques DOS ou injections
Limitar quantidade de request também é importante para evitar diretamente o DOS


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Uma arquitetura de mensageria server para permitir a comunicação entre sistemas ou serviços de forma sincrona, ou seja, 
sem que um precisa esperar o outro  terminar o processamento. 
Ela utiliza filas ou tópicos de mensagens para enviar e receber dados entre diferentes componentes, garantindo que as informações não se percam
mesmo que algum serviçoe esteja temporariamente fora do ar então acabamos reduzindo a dependencia e melhoramos a escalabilidade e resiliencia.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A arquitetura SAGA garante consistencia de dados em transações distribuidas entre micro serviços
ou seja é uma estratégia para manter a consistencia de dados entre microserviços, dividindo uma transação em etapas locais.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma forma de gerenciar e automatizar o Kubertes usando o Git como fonte de verdade,
aplicando automaticamente no cluster as configurações versionadas no repositório

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Caso de sucesso no projeto MES cilindros - CSN projeto legado e de alta resolvemos 4 novas telas seguindo o padrão do projeto tecnologias utilizadas C# WEBFORMS,  arquitetura SOAP com comunicação por barramento que inclusive rendeu uma parabenização ao time no linkdn, como eu sempre passei status report e sempre tinha entendimento do que estava ocorrendo no projeto fui convidado a assumir  a posição de lider técnico no projeto documental um projeto


