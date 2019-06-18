import { User } from '../user';
import { Reaction } from '../reactions/reaction';
import { DisReaction } from '../disreaction/disReaction';

export interface Comment {
    id: number;
    createdAt: Date;
    author: User;
    body: string;
    reactions: Reaction[];
    disReactions: DisReaction[];
}
