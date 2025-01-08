namespace Backend.Protocol;

public enum MessageType
{
    HELLO,                      // annonce de départ
    GOOD_BYE,                   // annonce d’absence           
    MEDIA_STATUS,               // Donné de réponses à une demande de contenu
    MEDIA_STATUS_REQUEST,       // Demande de contenu
    MEDIA_CONTENT_REQUEST,      // Demande du fichier entier
    MEDIA_CONTENT               // Envoie du fichier entier
}
