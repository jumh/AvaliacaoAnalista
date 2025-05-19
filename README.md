# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
1 - Codebase: A aplicação deve ter apenas um código-fonte, podendo ter várias instâncias (branches) e implantações, porém todas vindas do mesmo lugar.
2 - Dependencies: A aplicação deve ter todas as bibliotecas externas declaradas em um lugar que seja de fácil acesso (algo semelhante a um .env), para que qualquer pessoa que instale e tente executá-la consiga ter sucesso independente da máquina usada.
3 - Config: Informações sensíveis como conexões de banco de dados e chaves de APIs devem ser armazenadas no ambiente (variáveis de ambiente) e não no código.
4 - Backing Services: Recursos externos, como banco de dados e mensageria, devem ser tratados de forma com que a aplicação consiga conectar e desconectar deles, sem precisar mexer no código.
5 - Logs: O sistema não deve tratar os logs de forma local. Deve-se utilizar de ferramentas para simplificar o monitoramento e a centralização dos logs.
6 - Processes: O sistema deve manter os dados em memória independente de requisições, permitindo escalabilidade e, geralmente, utilizando cache.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Camada de apresentação (interação direta com o usuário), camada de aplicação (foco nos casos de uso gerados anteriormente), camada de domínio (foco nas regras de negócio), camada de infraestrutura (utilização de recursos externos como conexão com banco de dados, APIs externas, mensageria, cache, etc.) e camada de persistência (manuseio de ORMs para persistir as informações no banco de dados).


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** Em geral, a arquitetura SOA utiliza de servições grandes e reutilizáveis, sendo pouco escalável e facilitando integrações. A arquitetura de microserviços usa serviços pequenos e independentes, tendo alta escalabilidade e requerindo uma maior utilização de devops e pipelines de CI/CD.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** O objetivo do API Management é gerenciar e monitorar APIs de forma centralizada, atuando como uma camada entre quem vai utilizar a API e quem está produzindo esta, oferecendo melhor segurança e versionamento do código.
Vantagens: Segurança, monitoramento, melhor versionamento e fácil disponibilização de documentação.
Desvantagens: Maior custo, complexidade na configuração do projeto e possível aumento no prazo da entrega.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Class é um tipo por referência, como herança e Struct é um tipo por valor, sendo imutável.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** .NET roda apenas no Windows e é utilizando para aplicações desktop (instaláveis). .NET CORE é independente de sistema operacional e serve para APIs REST e microsserviços.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** REST possui uma comunicação através de JSON, tem ferramentas que facilitando seu teste, é maior utilizado porém menos performático. GRPC utiliza de comunicação binária, suas ferramentas de teste são mais complexas porém é melhor performática do que APIs REST.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** Em um SPA, as rotas são feitas do lado do cliente. Sendo assim, o browser não recarrega o navegador quando há navegação entre páginas, ele apenas troca o componente mantendo o estado da aplicação.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** É um conjunto de práticas que servem para integrar o desenvolvimento com a operação, tornando tanto o código quanto a parte de automatização de testes, deploys e monitoramento da API uma única responsabilidade.


10. Explique sobre um método agile.

**Resposta:** Basicamente é uma metodologia de gerenciamento de projeto onde, através de funções bem definidas (PO, SM e time DEV), divide-se as tarefas em sprints (iterações de funcionalidades) e backlog (lista de funcionalidades). A cada sprint, uma parte do sistema é entregue, contendo algumas "reuniões" como daily, review e retrospective. O maior e mais utilizado método agile é o Scrum. Meu TCC do curso técnico foi uma aplicação de gerenciamento de projetos utilizando o Scrum.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI é a integração contínua do código, sendo o processo de integrar, testar e validá-lo a cada commit. Já o CD é a automatização do código já testado em ambientes. Algumas ferramentas muito comuns são o Jenkins e o Azure DevOps.


12. Qual a diferença entre Docker e Containers.

**Resposta:** Container é o conceito de ambientes isolados que executam aplicações de forma independente. Docker é uma plataforma/ferramenta que serve para gerenciar os containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Assim como o Docker, Kubernetes é um gerenciador de containers, porém mais simples. O OpenShift é um "aprimoramento" do Docker, contendo também CI/CD, maior segurança e controle de acesso.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** As principais vantagens são a reutilização de serviços, fácil manutenção, integração entre sistemas e modularização. As desvantagens são a dependência de disponibilidade externa, necessidade de segurança externa (devido a sua exposição) e dependência da latência da rede. Para se utilizar uma API, é necessário se preocupar com a parte de autenticação dela, seu versionamento, o monitoramento de sua disponibilidade e um possível limite de uso dela.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Através de autenticação por JWT ou OAuth2, monitoramento de logs, limite de acesso por usuário, validação de input, utilização de HTTPS, configuração do CORS, cuidados com o código como exposição do .env publicamente, etc.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Permite a comunicação assíncrona entre serviços e uma maior resiliência no sistema. Ela usa de filas para garantir que mensagens sejam entregues mesmo com falhas temporárias e não dependendam de respostas de requisições terceiras.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** SAGA é um padrão de gerenciamento de transações distribuídas onde em vez de uma transação única, ela é dividida em uma sequência de eventos locais com ações compensatórias caso algo falhe.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** GitOps é uma prática que visa utilizar o GIT como forma de unificar o desenvolvimento e a operação. Com o Kubernetes, é possível utilizar de ferramentas que leem o repositório e sincronizam com o cluster do container.


19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** O projeto onde tive maior destaque foi na Octalink, onde fiz toda a parte de integração bancária do sistema, utilizando Flask para a integração de APIs de open-finance e APIs únicas por banco. A necessidade deste projeto veio a tona pois o time de financeiro estava muito sobrecarregado com a necessidade de cuidar de diversas contas dos clientes do ERP, sendo preciso uma automatização de coleta de extrato, pagamentos, notificações de vencimento de boletos, etc. Além da complexidade do código, tive como desafio a necessidade de compreender o que diferentes pessoas (time DEV, time de financeiro e clientes) entendiam como necessidades e executar de forma com que o código seja limpo, a entrega seja eficaz e o mais rápida possível para evitar o gargalo no financeiro, além de tomar cuidado com a segurança do código, já que são dados extremamente sensíveis.