# ImmersionEpitaMario

## Architecture

* ```__Subject``` : Contient le pdf du sujet
* ```Asset``` : Contient tous les éléments que l'on va utiliser pour le sujet
    * ```__Scenes``` : Dossier contenant toutes les scènes du jeu
    * ```_Mario``` : Dossier contenant tout ce qui est en rapport à l'objet Mario
    * ```_Floor``` : Dossier contenant tous les sols/plateformes pour la création de niveau
    * ```Coins``` : Dossier contenant tout ce qui est en rapport à l'objet pièce
    * ```Corrections.zip``` : Fichier zipper contenant les corrections
    * Les autres ne sont pas encore utilisés dans le sujet.
* ```Library``` : Contient les librairies utiles à Unity pour la 2D
* ```Packages``` : Liste des packages que Unity doit charger lors de la première ouverture du fichier
* ```ProjectSettings``` : Parle pour lui-même
* ```UserSettings``` : Idem

## Notes

### Avant l'arrivée des lycéens :
* Le premier chargement est long => pensez à ouvrir 1 fois le projet avant l'arrivée des lycéens
* Ouvrir la scène d'introduction pour ne pas qu'il perde de temps à la chercher
* Et revenir sur le dossier Asset dans l'onglet 'Project'