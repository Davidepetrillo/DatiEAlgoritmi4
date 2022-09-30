/* 
 * One way circular List
 * Struttura archiviazione a catena di una tabella lineare, collegata per formare un anello 
 * ogni nodo è composto da dati e un puntatore al nodo successivo
 */

namespace DatiEAlgoritmi4
{

    class TestCircleLink
    {
        private static Node head;
        private static Node tail;

        public static void Init()
        {
            head = new Node("A");
            head.next = null;
            Node nodeB = new Node("B");
            nodeB.next = null;
            head.next = nodeB;
            Node nodeC = new Node("C");
            nodeC.next = null;
            nodeB.next = nodeC;
            tail = new Node("D");
            tail.next = head;
            nodeC.next = tail;
        }

        public static void Print()
        {
            Node p = head;
            do
            {
                Console.Write(p.data + " -> ");
                p = p.next;
            } while(p != head);

            Console.Write(p.data +" \n\n");
        }

        public static void Main(string[] args)
        {
            Init();
            Insert(2, new Node("X"));
            Remove(2);
            Print();
        }

        public static void Insert(int insertPosition, Node newNode)
        {
            Node p = head;
            int i = 0;

            // Sposta il nodo nella posizione di inserimento

            while(p.next!= null && i < insertPosition - 1)
            {
                p = p.next;
                i++;
            }

            newNode.next = p.next;
            p.next = newNode;
        }

        public static void Remove(int removePosition)
        {

            Node p = head;
            int i = 0;

            // Sposta il nodo sul nodo precedente che vuoi eliminare

            while (p.next != null && i < removePosition - 1)
            {
                p = p.next;
                i++;
            }

            Node temp = p.next;
            p.next = p.next.next;
            temp.next = null;
        }
    }
}

