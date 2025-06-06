# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta: Nunca ouvi falar dos 12 fatores**

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta: Eu diria, de cabeça, UI, Domain, Application, Infrastructure**

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:Não conhecia por SOA, mas entendi com uma pesquisa rápida, SOA é orientado á serviços, requests específicas para tarefas, enquanto microserviços, como o nome diz, gira em torno de pequenos serviços separados fazendo tarefas separadamente, como trabalho em um sistema legado, tenho mais contato com SOA, apesar de implementar alguns microserviços específicos também.**

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:Tive contato apenas com AWS, então, no meu ponto de vista, adiciona segurança, mas retém performance.**

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:Nunca usei struct, apenas class, que cria uma referência para o objeto, struct copia o valor, então não achei um caso de uso.**

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta: Não existe mais diferença. (6+)**

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:Nunca usei GRPC, apenas REST.**

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:As rotas são feitas via URL, ex. Nextjs e React Router**

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta: Nunca mexi muito com DevOps, só o que vi na faculdade, basicamente é um conjunto de práticas para entregas rápidas e constantes (ex. CI/CD).**

10. Explique sobre um método agile.

**Resposta:Novamente, vi na faculdade, fazemos muita coisa no automático no dia a dia e não damos os nomes próprios para as coisas. Scrum e kanban são os mais utilizados: scrum tem as dailies, planning, retro e review, conhecidas como cerimônias, as sprints são periodos de tempo onde tem certas entregas, por exemplo, de 15 em 15 dias, o ideal é não mudar o escopo, mas não é a realidade de muitas empresas. Já o kanban é algo tipo Jira ou Azure, onde tem o board com os cards e suas raias, e prioriza a entrega rápida e constante, podendo ter flexibilidade para mudança de escopo**

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta: Uso Github Actions apenas, mas não fui eu quem configurou, tem algumas automação no azure devops também. Em um resumo, muito grande, o CI é a integração do código individual com a base, e o CD é o deploy desse código em um build automático, mas não sei como funciona a fundo.**

12. Qual a diferença entre Docker e Containers.

**Resposta:O docker é uma espécia de biblioteca, ou aplicativo, para gerenciamento de containers, e estes são tipo como pacotes de projetos, quase como uma VM, mas da aplicação**

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:Nunca ouvi falar de OpenShift, Kubernetes é uma ferramenta de gerenciamento de containers**

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:API é boa quando queremos reutilizar uma lógica de dados para ser consumida de diversas fontes, fazendo o desacoplamento do front e do back end, e também do próprio código, isolando cada pedaço de informação para ser utilizada pelo front end, ou até por um cliente, ou outro serviço. Sobre desvantagens, acredito que seja a mesma desvantagem de tudo na internet, que é a segurança, como usamos protocolos https, precisamos de uma camada de segurança para evitar ataques ou informações sensíveis de vazamentos.**

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:Acho que com o uso de um middleware e authentication e authorization, mas confesso que nunca fiz uma API 100% completa do zero, meus projetos, na maioria não usaram API, e a minha API do trabalho já estava pronta nesse sentido, a única coisa próxima disso foi a API da faculdade onde eu coloquei autenticação e autorização para login e paginações (React + .NET).**

16. Para que serve uma arquitetura de mensagerias?

**Resposta:Desacoplamento, escalabilidade e código assíncrono.**

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta: Não conheço a estratégia SAGA.**

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:Não utilizo GitOps.**

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta: Não consigo pensar em nenhum específico agora, já tive clientes relatando problemas de performance onde foi preciso refatorar diversas lógicas para tentar extrair o máximo de desempenho, e também fiz a criação de endpoints para clientes utilizarem para criação de coisas em lotes usando uma API, mas nada muito específico. Ambos foram usando .NET, 4.8 e 6, e usando ExtJS e React como front.**
