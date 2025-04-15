# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.
Resposta: Lembro de alguns
Codebase: Diz respeito ao ativo importante que é o codigo produzido no processo de criação de um software - dele que se fz o produto final – Por isso, a maneira com que o código-fonte é gerenciado torna-se um ponto central.
Dependencias: Artefatos externos necessário separa rodar a aplicação corretamente, tipo uma biblioteca, uma lib, ocx, ou mesmo ecosistema, etc
Configs: trata de configurações ou parâmetros que o projeto pode necessitar para rodar, e que também possam variar entre ambientes onde o mesmo será executado


2. Quais são as principais camadas no desenvolvimento de um software?
Resposta: camada de apresentação (front - onde tem a entrada e em sua maioria a saida dos dados), camada de logica(local onde ha o gerenciamento da logica de negocio), camada de dados (onde se armazena os dados).


3. Diferencie Arquitetura SOA X Arquitetura microserviços.
Resposta: SOA é um design de natureza monolítica orientado a serviços e baseado em XML, são desenvolvidos para executar inúmeras tarefas de negócios, enquanto os microsserviços são criados para executar uma única tarefa/contexto de negócios
Também possui uma única camada de armazenamento de dados que é compartilhada, ja os microsserviços dedicam principalmemnnte um banco de dados ou outro tipo de armazenamento aos serviços que precisam dele.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.
Resposta: API Management tem como objetico crair, publicar, proteger e gerenciar de forma geral as API's de forma centralizada dos multiplos serviços
As Vantagens incluem maior controle, segurança, escalabilidade e agilidade na implementação de APIs já as desvantagens incluem custos operacionais e complexidade de gestão


5. Qual a diferença entre uma Struct e uma Class?
Resposta:Struct é um tipo próprio valorado(armazenam valores), enquanto a classe é uma referência. Além disso, a struct é alocada na stack por padrão, enquanto a classe só pode ser alocada no heap


6. Explique a grande diferença entre .NET e .NET CORE.
Resposta: .NET Framework é específico para aplicativos desktop e web no sistema operacional Windows, enquanto o .NET Core é uma plataforma multiplataforma e de código aberto, mais leve e robusto.


7. Quais as principais diferenças entre REST e GRPC?
Resposta: gRPC usa HTTP2, é mais rápido e eficiente, ja o REST usa JSON com HTTP, é mais simples e amplamente usado;


8. Explique como funciona um gerenciamento de rotas de uma SPA.
Resposta: Ele identifica uma mudança de URL e substitui pela renderização do componente na página. Trechos da página são carregados quando uma rota é acionada, não há a necessidade de carregar a página inteira.


9. Falando sobre DevOps, comente o que conhece sobre.
Resposta: DevOps é uma metodologia de desenvolvilemto que combina a integração entre desenvolvimento e operações, o objetivo é melhorar a integração entre equipes, eliminando barreiras promovendo cultura de comiunicacao aberta focando em automação, entrega contínua e colaboração contínua.


10. Explique sobre um método agile.
Resposta: É uma abordagem de gerenciamento de projetos que se destaca pela sua flexibilidade e adaptabilidade. Ela se baseia em um conjunto de princípios que priorizam a colaboração, a entrega contínua de valor e a capacidade de resposta a mudanças


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.
Resposta: CI (Integração Contínua) focado em testes e integração de código;
CD (Entrega/Deploy Contínuo) automatiza a entrega de determinada versão de software.


12. Qual a diferença entre Docker e Containers.
Resposta: A tecnologia Docker usa o kernel do Linux, recursos do kernel e namespaces para segregar processos. Assim, eles podem ser executados de maneira independente. O container é um ambiente isolado


13. Qual a diferença entre Kubernetes e Openshift?
Resposta: Kubernetes é uma ferramenta para controle e gerenciamento containers. Openshift é uma versão empresarial do Kubernetes.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?
Resposta: Vantagens: Integração de Sistemas, Automatização de processos, Inovação e Criação de Novos Serviços, Aumento da produtividade, Decisões baseadas em dados
Desvantagens: segurança, versionamento, latência, garantias de ACID; Cuidados: autenticação, limitação de acesso e documentação.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?
Resposta: Por meio de autenticação (OAuth, JWT), criptografias e assinaturas, HTTPS, validação de dados de entrada e controle de acesso (rate limit, CORS).


16. Para que serve uma arquitetura de mensagerias?
Resposta: É usada para processar, enviar, receber, redirecionar e monitorar mensagens compartilhadas entre sistemas integrados. Os serviços não dependem de respostas imediatas e podem enviar eventos ou comandos para uma fila ou tópico


17. Explique a estratégia SAGA em arquitetura de microservice.
Resposta: É um padrão de design que ajuda a manter a consistência de dados em sistemas distribuídos coordenando transações em vários serviços


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.
Resposta: O GitOps é um modelo eficiente para gerenciar infraestrutura e aplicativos de software, especialmente em ambientes baseados em Kubernetes. Ele permite que qualquer desenvolvedor que usa git implante novos recursos no Kubernetes, mantendo os mesmos workflows entre o desenvolvimento e as operações


19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.
Resposta: Utilizei: winform, c#, oracle e websocket
A rotina: ROP de Suicídio. Após o medico prescrever/evoluir os dados do paciente e salvar, a rotina de trigger aplicava um algoritimo da pscologia nos dados informados pelo medico, caso o fluxo entrasse na regra, o sistema notifiva o medico com mensagem grande na tela informado o risco,
bem como enviava emails aos psicologos informado-os do ocorrido. Na maioria das vezes, ao encerrar a atendimento, os psicologos ja esparavam o mesmo na porta para para dar continuidade ao pro edimento pisicologico.

