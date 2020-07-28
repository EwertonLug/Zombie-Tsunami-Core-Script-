# Zombie-Tsunami-Core-Script-
## Lógica
A lógica implementada é parecida com a de um Multiplayer. 
Os players vão estar em uma lista e nessa lista apenas um player vai ser o master.
Os demais vão apenas seguir o master.
Se o master morrer passasr para o próximo.
## Principais métodos
FollowPivot - Caso o player da lista não seja o master, vai apenas seguir o pivô.
pivô = [n-1], onde n é o index do player que não é master.

UpdateMasterPlayer - Toda vez que um player morre, esse método envia para os demais player o atual master na lista.
