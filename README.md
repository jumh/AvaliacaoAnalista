# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

#### 1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

- Base de Código:
A aplicação deve ter um único repositório versionado que serve como a fonte principal. Mesmo que esteja em vários ambientes (produção, teste), o código é sempre o mesmo.

- Dependências:
Todas as bibliotecas e ferramentas que a aplicação usa devem estar declaradas (por exemplo, no package.json ou requirements.txt), para evitar erros de ambiente.

- Configurações:
Tudo que varia entre ambientes (como senhas e URLs) deve ficar fora do código, usando variáveis de ambiente. Assim o código pode ser o mesmo em produção e desenvolvimento.

- Serviços de Apoio:
Bancos de dados, filas e outros serviços externos devem ser tratados como recursos plugáveis, acessados por configurações externas (como URLs), sem necessidade de mudar o código.

- Build, Release, Run:
A aplicação deve ter três fases separadas:

- Build: compila o código;

- Release: junta o código com as configurações;

- Run: executa a aplicação.

- Logs:
A aplicação deve gerar logs formatados e deve armazenar, visualizar ou processar esses logs.

#### 2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
As principais camadas geralmente adotadas são:
- Apresentação (Front-End/UI): Interage com o usuário e exibe informações. Responsável pela experiência visual e entrada de dados.

- Aplicação/Serviços: Coordena a lógica da aplicação, chamando regras de negócio e serviços.

- Domínio/Modelo/Entidades: Representa os conceitos e regras centrais da aplicação, independente de tecnologia.

- Infraestrutura: Cuida da comunicação com bancos de dados, APIs externas e recursos técnicos.

- Cross-cutting: Funcionalidades comuns a todas as camadas, como segurança, logging, autenticação e monitoramento.

#### 3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
- **SOA (Service-Oriented Architecture):** Estrutura aplicações como uma coleção de serviços, normalmente maiores e mais acoplados, frequentemente comunicando-se via ESB (Enterprise Service Bus), com governança centralizada e, muitas vezes, banco de dados compartilhado.
- **Microserviços:** Evolução do SOA com foco em serviços pequenos, altamente desacoplados, comunicação direta (HTTP/gRPC), cada serviço com seu próprio banco de dados e governança descentralizada. Facilita escalabilidade e deploys independentes.

#### 4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
- **Objetivo:** Centralizar o gerenciamento, monitoramento, segurança e versionamento de APIs em ambientes distribuídos.
- **Vantagens:** Segurança unificada, políticas centralizadas (rate limiting, caching), métricas, logs, versionamento facilitado e transformação de payloads.
- **Desvantagens:** Pode se tornar ponto único de falha, adiciona latência, aumenta a complexidade da arquitetura e pode gerar custos adicionais.

#### 5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
- **Struct:** Tipo de valor, alocado na stack, mais eficiente para objetos pequenos e imutáveis. Não suporta herança, cópias são por valor.
- **Class:** Tipo de referência, alocada na heap, suporta herança e polimorfismo. Cópias são por referência.

#### 6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
- **.NET Framework:** Plataforma tradicional da Microsoft, Windows-only, integração profunda com o sistema operacional, runtime único e sistema de build tradicional.
- **.NET Core (.NET 5+):** Open-source, multiplataforma (Windows/Linux/macOS), modular, performance otimizada, deploy self-contained e CLI tools unificadas. Ideal para cloud e ambientes modernos.

#### 7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
- **REST:** Arquitetura baseada em HTTP/HTTPS, manipulação de recursos via endpoints e métodos padrão (GET, POST etc.), comunicação stateless, geralmente usando JSON. Simples, escalável e ideal para integração entre sistemas diferentes.
- **gRPC:** Comunicação binária sobre HTTP/2, mais performático e leve, ideal para comunicação interna entre microserviços. Usa contratos via Protobuf, suporta streaming e chamadas bidirecionais.

#### 8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O gerenciamento de rotas em uma SPA (Single Page Application) usa a History API para manipular URLs sem recarregar a página inteira. O framework intercepta mudanças de rota e renderiza dinamicamente apenas os componentes necessários, mantendo o estado da aplicação no client-side e proporcionando navegação fluida.

#### 9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é uma cultura e conjunto de práticas que integram desenvolvimento e operações, promovendo automação, CI/CD, infraestrutura como código, monitoramento e colaboração contínua. O objetivo é aumentar a frequência e estabilidade das entregas, reduzindo o tempo de entrega e facilitando a escalabilidade. Ferramentas comuns: Docker, Kubernetes, Azure DevOps, Jenkins, Terraform.

#### 10. Explique sobre um método agile.

**Resposta:**
Scrum é um dos métodos ágeis mais conhecidos, baseado em ciclos curtos (sprints), papéis definidos (Scrum Master, PO, Time de Desenvolvimento) e cerimônias como Daily, Planning, Review e Retrospective, focando em entregas incrementais e feedback contínuo. Outro exemplo é o Kanban, que visualiza o fluxo de tarefas em quadros, facilitando o acompanhamento e priorização das entregas.

#### 11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Continuous Integration) automatiza o build e testes a cada commit, enquanto CD (Continuous Delivery/Deployment) garante que o código esteja sempre pronto para produção (entrega contínua) ou seja implantado automaticamente (deployment contínuo). Ferramentas: Azure DevOps, GitHub Actions.

#### 12. Qual a diferença entre Docker e Containers.

**Resposta:**
- **Containers:** Isolam aplicações e suas dependências no nível do sistema operacional, garantindo portabilidade e eficiência.
- **Docker:** Plataforma que facilita a criação, distribuição e gerenciamento de containers, oferecendo ferramentas como Docker Engine, Docker Compose e Docker Hub.

#### 13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
- **Kubernetes:** Plataforma open-source para orquestração de containers, automatizando deploy, escalonamento e gerenciamento.
- **OpenShift:** Distribuição empresarial do Kubernetes pela Red Hat, adicionando funcionalidades de segurança, UI e pipelines integradas, geralmente focada em ambientes corporativos.

#### 14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
- **Vantagens:** Desacoplamento, evolução independente, interoperabilidade, reuso de funcionalidades e integração facilitada entre sistemas.
- **Desvantagens:** Overhead de comunicação, desafios de versionamento, complexidade distribuída e riscos de segurança.
- **Preocupações:** Design cuidadoso do contrato, documentação clara, versionamento, segurança (autenticação/autorização, rate limiting), monitoramento e observabilidade.

#### 15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Utilizando autenticação forte (OAuth 2.0, JWT, OpenID), HTTPS, validação rigorosa dos dados, CORS restritivo, logging e monitoramento centralizado, e aplicando políticas de acesso adequadas. Também é importante seguir normas como LGPD e monitorar possíveis anomalias.

#### 16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Serve para desacoplar sistemas e permitir comunicação assíncrona entre componentes, melhorando escalabilidade, resiliência e desempenho. Exemplos: RabbitMQ, AWS SQS. É útil para processar grandes volumes de eventos e garantir que sistemas independentes troquem mensagens sem dependência direta.

#### 17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A estratégia SAGA executa cada etapa da transação em diferentes serviços de forma independente. Se uma etapa falhar, ações compensatórias são executadas para desfazer as operações anteriores, garantindo consistência eventual. Pode ser implementada via coreografia (eventos) ou orquestração (comando central).

#### 18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma abordagem onde todo o estado desejado do cluster (manifests, configurações, pipelines) é versionado no Git. As mudanças são aplicadas automaticamente ao ambiente via pipelines de CI/CD, garantindo rastreabilidade, automação e rollback fácil. No contexto do Kubernetes, isso centraliza e versiona a infraestrutura como código, aumentando a segurança e o controle.

#### 19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

 Um dos momentos mais marcantes da minha carreira foi também o meu primeiro grande desafio profissional. Entrei em um projeto de grande porte como QA, em uma equipe que desenvolvia um sistema robusto em PHP com Laravel — tecnologias completamente novas para mim, já que minha base era em .NET.
Logo no início, precisei sair da zona de conforto e aprender rapidamente PHP e Laravel para entender o sistema e conseguir contribuir de forma efetiva nos testes. Foi um desafio considerável, especialmente porque ninguém da equipe tinha experiência prévia com qualidade de software ou com ferramentas do ecossistema .NET.
Mesmo assim, consegui aplicar meus conhecimentos em C# com Selenium para iniciar a automação dos testes das partes mais críticas do sistema. Paralelamente, comecei a estruturar o processo de qualidade do zero, com as seguintes ações:

- Implementação de testes manuais;
- Criação de roteiros de validação;
- Elaboração dos primeiros relatórios de qualidade.

Com o tempo e muito estudo, consegui configurar uma pipeline de CI/CD no Azure DevOps, automatizando a execução dos testes. No entanto, percebi que os testes com Selenium estavam se tornando lentos. Com isso, iniciei uma pesquisa por ferramentas mais rápidas e encontrei o Cypress.
Sugeri a mudança na stack de testes — o que inicialmente gerou resistência, já que os testes já estavam sendo feitos em C#. Porém, ao apresentar  uma poc e com os ganhos de performance, legibilidade e integração com o front-end, conseguimos aprovar a migração. Como a equipe já tinha experiência com JavaScript, a transição foi rápida e colaborativa.
Migramos os testes de front-end para JavaScript com Cypress, o que resultou em:
- Redução de mais de 50% no tempo de execução dos testes;
- Maior clareza e manutenção dos scripts;
- Melhor integração com o restante do sistema e com a pipeline de CI/CD.
- Time comceçou a criar testes automatizados pra novas funcionalidades, aumentando a cobertura de testes.

Tudo isso ocorreu durante a pandemia, com o trabalho 100% remoto — o que adicionou mais um grau de complexidade, principalmente por ser a minha primeira experiência profissional e também o meu primeiro contato com o trabalho remoto.
Apesar disso, consegui me adaptar, aprender com o time e entregar uma uma parte do sistema coberta por testes que envolveu:
- Testes manuais;
- Automação de testes;
- Pipeline de CI/CD.
- Colaboração do time de desenvolvimento para garantir a qualidade do software.

Mesmo não tendo seguido na área de QA depois disso, essa experiência foi muito bacana. Aprendi muito sobre sobre colaboração, resiliência e evolução em equipe.
Essa vivência me mostrou que, com dedicação e oportunidade, é possível aprender qualquer coisa.
