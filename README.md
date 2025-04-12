# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Eu não conhecia o conceito Twelve-Factor App.
Creio que ser uma diretriz que ao seguir norteará como devemos conceber produtos de software com qualidade.
Eu sigo o Clean Code sugerido no livro de mesmo nome do Robert C. Martin, nele tem vários principios para se manter um código com efetividade e manutenibilidade,
dentre os conceitos os que mais se destacam são os principios SOLID onde se indica várias coisas como responsabilidade única em cada classe, o que gerará somente um motivo para alterações,
principio de inversão de dependencia onde para se usar uma determinada rotina, deve-se fornecer os recursos que ela espera, e diversas diretrizes para o uso de heranças/extensões de classes
para se evitar diversos tipos de acoplamento/complexidade desnecessária, e organização do código.
Além dos principios SOLID, indica também algumas boas práticas como KISS, DRY, YAGNI, que são acronimos em inglês para jargões para todo desenvolvedor que presa por um bom código seguir.
E um dos meus favoritos é a regra do escoteiro que indica deixar um local mais limpo/organizado de como vc encontrou/passou por ele.
Dito isso irei estudar sobre a questão levantada.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Esse assunto é bem amplo, varios autores e várias arquiteturas abordam nomes diferentes, mas em suma seria a separação por responsabilidades, onde segregamos regras de negocio (Bussiness, Aplication, Services),
Entidades/Modelagens (Model, Entity, Domain), Infraestrutura (Database, Infraestruture, Infra, Interface) e Apresentação (Controllers, API, e View, UX, UI, quando se tem front-end no mesmo projeto).

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA é arquitetura baseada em serviços,eu particularmente só utilizei em minha jornada como desenvolvedor para integrações entre sistemas, sempre foi para receber dados externos e armazená-los sob nosso sistema ou enviar alguns dados para outro sistema.
Microsserviços são partes desacopladas com funções unicas, leves e simplificadas onde podemos gerar uma disponibilidade maior quando-se comparado a monolitos.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Não conheco o termo API Management, mas pelo nome deve ser algumas diretrizes de melhores práticas para se "gerenciar" APIs, e falando-se em gerenciar, ai temos uma abrangencia vasta,
Onde pode ser como condizirmos as ativides de levantamento de requisitos, desenvolvimento do produto de software, como realizar manutenções, documentação, segurança, observabilidade, disponibilidade, rastreio
e todos os outros pilares que envolve um produto de software moderno de hoje em dia.
Irei pesquisar sobre isso também.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Para a lingagem C# Struct está mais relacionado a possibilidade de simplificar uma estrutura, onde se preferencialmente tipos primitivos e não precisa dos controles que uma classe possui,
e a principal diferença é que se uma Struct possuir somente tipos primitivos, preferencialmente o runtime irá armazena-lo ma memória mais "rapida", não lembro se é heap ou se é stack, a 
classe por em sua definição ser um tipo complexo ou possuir tipos complexos dentro dela fica é armazenada na memória mais "lenta".
A diferença de velocidade em si não é tão relevante, ambas são memórias "rapidas" mas para atingir mais efetividade, tem-se a atentar esses detalhes de arquitetura.
Ou seja, uma Struct se seguir com somente tipos primitivos irão ser mais rapido seu processo se comparados com uma classe possuindo os mesmos tipos de atributos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET é um framework que tem diversas facilidades para desenvolvimento da Microsoft, costumeiramente chamanos de .NET puro ou "full framework", ou até mesmo .NET Framework.
já o .NET CORE é a evolução dessa plataforma, onde como toda evolução se expande os horizontes seja ele de plataformas aceitas, que de cabeça é o que mais tem nas diferenças delas,
onde nativamente podemos rodar numa maquina Linux, e ambientes virtualizados com maior facilidade. Mais compatibilidade nativa com demais arquiteturas.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST é o protocolo que mais utilizamos em Aplicações WEB, para se trafegar dados por HTTP/HTTPS, GRPC eu sei que seria a tecnologia avançada que promete a substituição do REST.
Agora as particularidades eu não possuo conhecimento.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
As SPAs foram concebidas para gastar menos menória e serem mais rapidas para os navegadores, deixando a carga de trabalho reduzida e também a responsabilidades do server-side,
Cada rota é responsável por um determinado componente / pedacinho do sistema, que é carregado sob demanda no cliente-side, e também provem segurança quando aplicado
um gerenciamento de acesso das mesmas, onde podemos permitir ou negar de acordo com as credenciais em um token ou cookie no client-side.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é a junção do desenvolvimento e operação, por definição, mas usamos esse conceito para descrever processos que acontecem em ambientes virtualizados, seja uma configuração de máquinas,
esteiras de publicação, controle de versão, automatização de rotinas, gestão de recursos. Seria uma aglutinação de funções de infra-estrutura por pessoas da area de desenvolvimento, ou 
de profissionais de infra que também aprenderam sobre a área de desenvolvimento. Hoje em dia tem até outro conceito que é DevSecOps, onde aglutina-se o conceito de segurançã da informação também.


10. Explique sobre um método agile.

**Resposta:**
Agile que usamos de forma simplificada para referir ao modelo de evolução distribuida, diferente de antigamente onde-se tinha o modelo incremental, esse termo é fortemente ligado
a implementação e entrega contínua de valor. Quando falamos sobre software seria desmembrar as funcionalidades o mais granular possivel para que seja atacada de forma mais rapida e paralela
o possível, onde entregamos valor de forma mais rapida e disponibilizamos funções mais críticas de forma que no momento da disponibilização, o cliente já pode usufruir da melhoria, não 
precisando aguardar o periodo total do desenvolvimento do sistema completo. Sobre a atualidade tem muito se discutindo sobre se ainda faz sentido seguirmos esse manifesto. Minha opinião
é que precisamos avaliar cada uma das propostas das metodologias ágeis e ver se faz ou não sentido aplicalas olhando para o projeto e para o produto. Muitos lugares já aglutinam processos
e enxugaram funções que as metodologias indicam seu uso. 

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI e CD esta fortemente ligado com o desenvolvimento incremental de um produto de software, onde se entrega de forma continuada atualizações de um software, desse modo engloba-se tanto 
novas funcionalidades quanto correções.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker é uma plataforma, onde se executa um Container. Container é um local onde podemos instalar imagens de aplicativos/sistemas customizáveis.
Ou seja, na plataforma Docker podemos subir vários Containers com vários sistemas operacionais/aplicações de forma mais leve, pois usa-se de virtualização.
Existem também Orquestradores como o K8s que facilitam a vida de quem usa Containers.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Ambos são Orquestradores de Containers, Kubernetes tem uma fatia maior de mercado por ser OpenSource, estar ligado fortemente quando se fala em Orquestramento de Conteiner do mesmo jeito
que se pensa em Docker quando se fala sobre Container. O Openshift tem mais funcionalidades e facilitadores, porém ele não possui distribuição gratuita.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Em relação a que? Sistemas desktop ? Não entendi o que se espera com essa pergunta.
Bom se for em relação a outros tipos de sistemas, é que separamos responsabilidades, podemos escalar sua disponibilidade. APIs são utilziadas em sistemas Web então suas principais desvantagens seria falta de segurança
comparados a sistemas desktop, se utilizados em máquinas sem acesso a internet possuem uma grande barreira para ataques lógicos/virtuais.
APIs possuem a desvantagens de não funcionar em um modo de contingencia caso não se tenha conexão de internet, mas em contrapartida com computação em nuvem podemos acessar a plataforma por
diversos outros dispositivos além de um computador.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Utilização de protocolos de segurança como HTTPS, SSL, utilizar-se dos conceitos de Autorização e Autenticação, manter politicas de acesso, autenticação em dois fatores para utilizações mais criticas.
Criptografia e garantia de cumprimento da LGPD.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Para se intercomunicar microserviços de forma mais rapida e resiliente, tanto quanto agilizar processos que demandam processamentos assincronos.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
SAGA é o conceito que se trata de manter a consistencia entre sistemas, seja no caso de transações como informações disponíveis entre eles ou entre seus respectivos bando de dados.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Desconheço o conceito de GitOps, confesso que nunca vi, mas pela junção do Git mais Ops, crei que seja algo relacionado a operações com controle de versão.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Existia uma rotina no sistema que desenvolvia que realizava a baixa de boletos de contas a pagar, receber. Nele as pessoas precisavam realizar a rotina manualmente, e por vezes não as faziam em tempo hábil.
Desenvolvi um microsserviço que realizava a integração com instituições bancárias e realizava esse processo de foram automatizada. Utilizei um agendador que rodava pelo HangFire
e durante algumas vezes no dia realizava a consulta e baixa dos boletos de forma automática, o Microsserviços foi feito em .NET Core. Os desafios foram realizar a comunicação com os representantes 
bancários, documentação imprecisa/escassa, mas com muita persistência e resiliência consegui integrar com vários bancos.