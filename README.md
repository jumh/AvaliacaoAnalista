# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.
Codebase: Base de codigo por app com versionamento tipo GIT. Dependecias: toda dependecia deve estar declaradas no csproj ou mesmo nuget. Config: as configs de ambiente devem estar fora do codigo via variaveis de ambiente. Services externos: todo services externo deve ser tratado como o tal para facilmente ser substituido sem alterar muito codigo exemplos bancos redis filas. Processes: o app roda um ou mais processo de staleless nao deixar guardado em memoria local do app. Logs: devem ser fluxos de eventos enviado para outros sistemas de analise grafana elk, e nao deixar no local.


2. Quais são as principais camadas no desenvolvimento de um software?

Presentation(Web/API), Application(Logica da orquestracao e casos de uso), Domain(Regras de negocio, entidades, servicos de domain e interfaces), Infratusture(Repos, Services externos, Bds).


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

Soa e mais voltado para grandes sistema integrados com servicos reutilizaveis, ja o micro sao pequenos independentes e com deploy isolado o nome mesmo ja dis micro.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

Objetivo e gerenciar, monitar a api`s, vantagem que eu vejo controle de acesso, logs, swagger para doc e versions, cache e roteamento. Desvantagens, latencia, custo se for nuvem.


5. Qual a diferença entre uma Struct e uma Class?

A struct nao suporta heranca basicamente ja a Class suporta heranca e polimorfismo.


6. Explique a grande diferença entre .NET e .NET CORE.

.net e antigo mas focado em tecnologias da epoca tipo windows e sistema legado, ja o core e focado em multiplataformas, modularidade e containers.


7. Quais as principais diferenças entre REST e GRPC?

rest usa http com json ja o grpc usa http/2, em tese o rest e melhor para sistema publicos e abertos ja o grpc e banckends internos e sistemas de performance


8. Explique como funciona um gerenciamento de rotas de uma SPA.

no spa no angular o roatemento e feito no cliente, o spa escuta a url e carrega o compomente sem recarregar a pagina.


9. Falando sobre DevOps, comente o que conhece sobre.

Vejo devops como muito mais do que pipeline e deploy e uma mentalidade que une desenvolvimento e operacoes com foco em agilidade, automacao, qualidade continua e entrega de valor rapido e seguro. Uso muito em testes automatizados com xunit, ate deploy automatizado de microservicos em ambientes containerizados com docker e kubernetes. Acho que devops e mais sobre cultura e confianca.


10. Explique sobre um método agile.

scrum e o mais usado e o que eu estou mais acostumado basicamente e sprints de 1 a 2 semanas aonde rodao os epicos e as history aonde e feito a planning e o time validas as horas de cada history define se entra ou nao na sprints e e nas dailys sao comentando sobre o andamento junto ao po, dev team e scrum master, basicamente e isto.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

ci e integracao continua e cada commit e um build e cd e deploy continuo o deploy o acontece de forma automatizadas nos ambientes


12. Qual a diferença entre Docker e Containers.

docker e a ferramenta que gerencia e implemtenta os contatiners ja o containers em si e um ambiente com tudo o que eu preciso para rodar a app.


13. Qual a diferença entre Kubernetes e Openshift?

Basicamente eu entendo que o kubernetes e opensource ja o openshift e um contruida em cima do kubernets com algumas coisas de ci/cd e com gestao de permissao.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

de vantagens vejo reutilizacao, escalabilidade, melhor definicao de responsabilidades, ja desvastagens e lag de rede e complexidade de governanca, ja preocupacao vejo que auth, versionamento e logs.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

acho que no basico oauth2, jwt, claims, rate limiting, validar xss e sql injection, https obrigatorio e logs.


16. Para que serve uma arquitetura de mensagerias?

ajuda a tirar o leg do servico em vez de chamar direto publico na fila e outros app consome quando podem.


17. Explique a estratégia SAGA em arquitetura de microservice.

e mais para orquestar as trans distribuidas do microsservicos, tanto para orquestrada service central manda nos passos, quanto coreografada os services reagem a enventos uns dos outros e as etapas tem seus rollback em casos de dar ruim.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

a e uma fora de fazer deploy automatizado no kubernets com o git.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

um dos cases mais relevantes que participei foi na lopes, onde assumi o papel de lider tecnico na reestruturacao de um sistema corporativo legadao, o maior desafio era modernizar esse sistema sem impactar os fluxos criticos da operacao mantendo a escalabilidade e melhorando a performance das apis. Implementei uma nova arquitetura baseada em clean architecture com separacao clara de camadas e de DDD para organizar a logica de negocio. optei por um modelo de microservicos com .NET core versionado com Git/Bitbucket e publicado em containers docker orquestrados via Kubernetes. Do ponto de vista de infraestrutura usei o Redis para controle de sessoes e cache, logs estruturados e dashboards no kibana, Tambem configurei CI/CD com github actions para automacao completa dos pipelines.O resultado foi um app mais modular de facil manutencao com tempo de resposta reduzido e muito mais confiavel. Essa reestruturacao nao so resolveu gargalos tecnicos mas tambem aumentou a confianca da area de negocio nas entregas do time de tecnologia.


