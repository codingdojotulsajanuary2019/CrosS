from sl_node import Node
class SL_list:
    def __init__(self):
        self.head = None
    
    def ass_to_front(self,value):
        new_node = Node(value)
        new_node.next = self.head
        self.head = new_node
        return self