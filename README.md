# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Eu não conhecia o Twelve-Factor App, mas depois de pesquisar, entendi que é um manual de boas práticas para construir apps modernos que rodam bem na nuvem (como no Docker ou Kubernetes). O objetivo é que o aplicativo seja fácil de escalar e de gerenciar.

2. Quais são as principais camadas no desenvolvimento de um software?

De forma resumida, as principais são: Camada de Apresentação (A Tela), Camada de Negócio, Camada de Dados. Em meus projetos .net, gosto de dividir as minhas APIs em 4 camadas: Api, Application, Domain e REpository. API (Apresentação): Recebe requisições HTTP e chama a camada Application. Application: Coordena o fluxo, usa o Domain e o Repository. Domain (Domínio): Contém as regras de negócio cruciais e entidades. Repository: Lida com o acesso e a persistência dos dados (o banco).


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

Eu não sabia o que era SOA, mas aprendi que significa Arquitetura Orientada a Serviços. A diferença é: SOA usa serviços grandes e comunicação centralizada (ESB). Microserviços usa serviços pequenos, independentes e comunicação descentralizada.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

O API Management é o guardião central que protege, gerencia e controla todas as suas APIs. Vantagens: Mais segurança e controle de acesso e limites de uso. Desvantagens: Custo e adiciona um ponto de falha extra com mais atraso (latência).


5. Qual a diferença entre uma Struct e uma Class?

As classes funcionam como um endereço na memória: elas ficam na heap e, quando você copia uma variável, as duas acabam apontando pro mesmo lugar.

Já as structs são diferentes — elas guardam o valor em si, ficam na stack e, quando você copia, é feita uma nova cópia independente, sem ligação com a original.


6. Explique a grande diferença entre .NET e .NET CORE.

O .NET (ou .NET Framework, o antigo) só rodava no Windows e era "pesado", já o .NET Core (que hoje se chama só .NET) é a versão moderna, leve, que é multiplataforma (roda em Linux, macOS e Windows) e tem performance muito melhor. O .NET Framework parou de evoluir, enquanto o .NET (Core) é o futuro e recebe todas as novidades.


7. Quais as principais diferenças entre REST e GRPC?

Eu não sabia o que era gRPC, mas descobri que é um sistema de comunicação criado pelo Google, bem mais novo que o REST.

Aqui está a diferença, bem direta:

O REST usa o HTTP 1.1, troca dados em formato JSON (que é texto e "pesado"), é fácil de ler e o padrão que todo mundo conhece. Já o gRPC usa o HTTP/2, troca dados em formato Protobuf (que é binário e "leve"), é muito mais rápido e eficiente, e foca na comunicação de alta performance entre serviços (microsserviços).


8. Explique como funciona um gerenciamento de rotas de uma SPA.

Numa SPA, o gerenciamento de rotas cuida de trocar as “páginas” sem recarregar o site todo. Ele basicamente escuta as mudanças na URL e mostra o componente certo pra cada rota. Tudo acontece no front, o navegador só muda o que precisa — rápido e suave, sem aquele refresh chato.


9. Falando sobre DevOps, comente o que conhece sobre.

Bom, eu tenho um certo conhecimento na área de DevOps. Sei trabalhar com Docker, criando e gerenciando containers pra deixar os ambientes mais padronizados. Também entendo bem de CI/CD, pra automatizar o processo de build, teste e deploy. Utilizo bastante o Jenkins e estou estudando git Actions. Tenho um conhecimento básico de Kubernetes, sei o conceito de orquestração e como ele ajuda a escalar aplicações. E também já vi um pouco de IaC, entendendo a ideia de usar código pra montar e gerenciar infraestrutura, tipo com Terraform. Ainda não sou expert em tudo, mas já tenho uma boa noção de como essas peças se conectam dentro do mundo DevOps.


10. Explique sobre um método agile.

Tenho vivência com métodos ágeis, principalmente Scrum e Kanban. Já trabalhei em times usando sprints, planejamento, daily stand-ups, reviews e retrospectivas. A ideia é entregar valor contínuo, ajustar prioridades conforme o feedback e manter o time alinhado e produtivo. No Kanban, por exemplo, já gerenciei fluxo de trabalho visualizando tarefas em colunas, controlando WIP (work in progress) e buscando melhoria contínua do processo.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

"Tenho experiência com CI/CD, usando principalmente Jenkins no dia a dia. Basicamente, CI é quando o time integra o código com frequência, e o Jenkins roda builds e testes automáticos pra garantir que nada quebre. Já o CD garante que o que tá pronto pode ser entregue rápido, de forma segura, no ambiente de produção ou homologação. No dia a dia, uso o Jenkins pra automatizar builds, rodar testes e até deploys, o que ajuda a manter entregas rápidas e confiáveis.


12. Qual a diferença entre Docker e Containers.

Containers são ambientes isolados que executam uma aplicação com todas as suas dependências, garantindo que ela rode de forma consistente em qualquer lugar. Docker é uma ferramenta que facilita criar, gerenciar e executar esses containers. Ou seja, o Docker é uma implementação prática para trabalhar com containers.


13. Qual a diferença entre Kubernetes e Openshift?

Eu já trabalhei com Kubernetes, que é uma plataforma de orquestração de containers, usada pra gerenciar deploys, escalabilidade e alta disponibilidade de aplicações em containers. Sobre OpenShift, eu não tenho experiência direta com ele, mas sei que é uma plataforma que também faz orquestração de containers e é baseada no Kubernetes, oferecendo ferramentas adicionais para deploy, segurança e gerenciamento de aplicações.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

API é uma forma de expor funcionalidades ou dados de uma aplicação pra outras aplicações consumirem. A vantagem é que facilita integração, reaproveitamento de serviços e separação de responsabilidades. A desvantagem é que, se não for bem projetada, pode gerar problemas de performance, segurança e manutenção. As principais preocupações são: garantir autenticação e autorização, versionamento da API, tratar erros de forma consistente e monitorar performance e consumo pra não impactar o sistema.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

Pra garantir segurança em APIs, é importante implementar autenticação e autorização fortes (tipo OAuth2 ou JWT), usar HTTPS sempre, validar e sanitizar os dados recebidos, aplicar rate limiting pra evitar abuso e monitorar logs e acessos. Também é importante versionar a API e manter atualizações de segurança do servidor e das bibliotecas que ela usa.


16. Para que serve uma arquitetura de mensagerias?

Arquitetura de mensageria é pra sistemas conversarem sem depender um do outro direto. Eles trocam mensagens por um intermediário tipo RabbitMQ ou Kafka, o que ajuda a deixar tudo mais escalável, confiável e menos travado se algum serviço cair.


17. Explique a estratégia SAGA em arquitetura de microservice.

Não tenho usado SAGA diretamente, mas sei que é uma estratégia pra lidar com transações distribuídas em microservices. Cada serviço executa sua parte e, se algo der errado, existem ações de compensação pra manter os dados consistentes.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

GitOps é quando a gente usa o Git como ‘manual de instruções’ pra tudo que rola no Kubernetes. Qualquer mudança no cluster, deploy ou configuração, é feita via commit no Git, e ferramentas aplicam isso automaticamente. Fica fácil de controlar, rastrear e versionar o que tá rodando.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

Um case de sucesso que participei foi a migração de uma API de .NET Framework 4.5.2 pra .NET Core 3.1. Foi bem desafiador: rolou muito erro de compilação, problemas em runtime e bibliotecas incompatíveis que precisei adaptar ou substituir. Durante o processo, implementei Docker pra containerizar a aplicação e usei MongoDB tanto como cache quanto pra persistência de dados, o que deixou o fluxo muito mais rápido. No fim, conseguimos modernizar a API, melhorar a performance e deixar tudo pronto pra evoluir com tecnologias mais novas.
