# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Auxílio da internet para elaborar resposta.

- **Base de código**: Uma única base de código rastreada por um sistema de versionamento, com múltiplos deploys.
- **Dependências**: As dependências devem ser explicitamente declaradas e isoladas.
- **Configurações**: Devem ser armazenadas em variáveis de ambiente, separadas do código.
- **Backing services**: Serviços externos (banco, cache) são tratados como recursos anexáveis.
- **Build, release, run**: São três fases separadas e bem definidas no ciclo de vida da aplicação.
- **Logs**: Devem ser tratados como streams de eventos contínuos e enviados para ferramentas de análise.

---

2. Quais são as principais camadas no desenvolvimento de um software?

UI; Serviço; Regra de negócio; Infraestrutura; Banco de dados.

---

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

SOA é uma abordagem mais tradicional e centralizada, geralmente com um barramento (ESB). Já microserviços são menores, 
mais desacoplados, cada um podendo escalar de forma independente e utilizando protocolos mais leves, como HTTP/gRPC.

---

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

API Management serve para facilitar segurança, autenticação, versionamento e monitoramento das APIs. Como ponto positivo, ele ajuda muito 
na governança. A desvantagem pode ser o custo e a complexidade inicial de configurar tudo corretamente.

---

5. Qual a diferença entre uma Struct e uma Class?

Structs são tipos por valor, ideais para dados pequenos e imutáveis, enquanto classes são tipos por referência, 
mais flexíveis e suportam herança, podendo estanciar nossas classes.

---

6. Explique a grande diferença entre .NET e .NET CORE.

.NET Core (agora .NET 6/7/8) é multiplataforma, com performance superior e mais leve. 
Já o .NET Framework é mais voltado ao Windows e sistemas legados.

---

7. Quais as principais diferenças entre REST e GRPC?

Auxílio da internet referente ao gRPC.

REST é mais amigável, baseado em HTTP e JSON, ótimo para integrações web. 
Já o gRPC usa Protobuf e HTTP/2, com desempenho melhor, especialmente em comunicação entre serviços.

---

8. Explique como funciona um gerenciamento de rotas de uma SPA.

Em uma SPA, o gerenciamento de rotas acontece no front-end. Mesmo com a mudança de URL, 
a página não recarrega totalmente — apenas o conteúdo visível é atualizado dinamicamente.

---

9. Falando sobre DevOps, comente o que conhece sobre.

Vejo DevOps como a união entre desenvolvimento e operações. 
Utilizando práticas como CI/CD, automação de testes e deploys, monitoramento e integração contínua para garantir entregas rápidas e seguras.

---

10. Explique sobre um método agile.

Scrum trabalha com ciclos curtos chamados sprints, entregas incrementais, reuniões regulares (como daily e review) 
e papéis bem definidos, como PO, SM e Dev.

---

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

CI é onde integra código automaticamente e roda testes. CD cuida do deploy automático após a aprovação. 
Costuma usar GitHub Actions e GitLab CI para isso, além de Docker e Kubernetes.

---

12. Qual a diferença entre Docker e Containers.

Docker é a plataforma usada para criar e gerenciar containers. 
Já container é a unidade executável isolada que empacota a aplicação e suas dependências.

---

13. Qual a diferença entre Kubernetes e Openshift?

Auxílio da internet referente ao Openshift.

Kubernetes é o orquestrador padrão para containers. 
Openshift é uma plataforma corporativa que já vem com Kubernetes, mas com recursos adicionais de segurança e CI/CD.

---

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

As APIs trazem flexibilidade, escalabilidade e integração. Mas é preciso cuidar de autenticação, documentação e versionamento.

---

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIs?

Uso de HTTPS, autenticação JWT ou OAuth2, validação de entrada e saída, limitação de taxa de requisição e logging para rastreabilidade.

---

16. Para que serve uma arquitetura de mensagerias?

Uso mensageria para comunicação assíncrona entre serviços, o que melhora a resiliência e desacoplamento (RabbitMQ ou Kafka).

---

17. Explique a estratégia SAGA em arquitetura de microservice.

Auxílio da internet para eloborar a resposta.

SAGA é usado para coordenar transações distribuídas. 
Ela permite executar passos com compensações caso algo falhe, usando coreografia (eventos) ou orquestração.

---

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

Auxílio da internet para eloborar a resposta.

No GitOps, toda configuração da infraestrutura e dos serviços são versionados pelo Git. 
A partir disso, ferramentas como ArgoCD fazem o deploy automático no Kubernetes.

---

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, 
cite tecnologias e os desafios enfrentados.

Realizei a migração de um sistema que utilizava o AWS Amplify com DynamoDB para uma nova infraestrutura baseada em serviços serverless,
utilizando Lambdas e uma API desenvolvida com Spring Boot. O principal desafio foi garantir que o sistema permanecesse disponível durante
todo o processo. Para isso, implementei soluções paliativas com microserviços em AWS Lambda, que atuaram como ponte até que a nova API 
estivesse completamente funcional. SEssa abordagem permitiu uma transição suave, sem impacto para os usuários.