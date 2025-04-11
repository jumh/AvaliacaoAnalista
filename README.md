# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** Ainda não tive oportunidade de utilizar essa metodologia.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Na arquitetura de 3 camadas temos: Apresentação (UI), Lógica de Negócio (Domain) e Dados (banco).


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** SOA é mais antigo e ideal para integração de vários sistemas e até legados. Microserviço é mais moderno e ideal para novas aplicações.
SOA costuma ser maior e mais complexo. Microserviço possui "módulos" menores com funções específicas.



4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**: Auxilia na gestão das APIs da aplicação. Pode monitorar e controlar as APIs no ambiente. 
Vantagens: Aumenta a segurança, facilita a documentação e automatiza a escalabilidade.
Desvantagens: Cria uma camada adicional ao sistema e gera custo adicional.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct: Imutável, não suporta herança e dados possui simples.
Class: Mutável, suporta herança e permite dados mais complexos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** O .NET Core é cross-platform e não funciona apenas no Windows como o .NET antigo.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST: Mais lento, mais fácil por ser texto e possui várias ferramentas simples para teste.
gRPC: Mais rápido, mais complicado por precisar compilar e depende de ferramenta específica.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** Ele identifica uma mudança de URL e substitui pela renderização do componente na página.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** É um conjunto de medidas a serem adotas por um time de desenvolvimento para melhorar o processo.


10. Explique sobre um método agile.

**Resposta:** Scrum é o que eu mais me adaptei e ajuda muito no processo e definição dos tempos de entrega.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** É uma parte importante do DevOps e sempre usei o Azure DevOps.


12. Qual a diferença entre Docker e Containers.

**Resposta:** Docker é uma plataforma de gestão de Containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Openshift é uma plataforma baseada em Kubernetes mas ainda não tive oportunidade de usar.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** APIs são vitais para uma aplicação e permitem integração fácil, mas gerenciar muitas pode ser um problema. A maior preocupação deve ser o controle de acesso e segurança.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** HTTPS, autenticação avançada e CORS.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Processar as requisições para uma API e gerenciar as respostas.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** Ainda não tive oportunidade participar de um projeto com SAGA.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** Ainda não trabalhei com Kubernetes.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** 
Trabalhei em uma empresa que utilizava Salesforce e por questões financeiras foi inviável continuar. Meu time de SI (Sistemas Internos) desenhou um projeto para substituir o Salesforce em 6 meses. Criamos o projeto utilizando .NET e como parte da lógica de negócio estava no Protheus, criamos uma integração entre os sistemas. Toda a base de dados foi migrada sem perdas. Toda a força de vendas da empresa passou a utilizar um sistema próprio.

Outra experiência mais recente foi um projeto de substituição do front-end de uma aplicação de gestão de SaaS, de .NET com VueJS para ReactJS puro. Participei do projeto desenvolvendo um framework de front-end independente para o sistema.

