import { FC, ReactNode } from 'react';

interface Props {
   onFinish: (values: {
      [key: string]: string;
   }) => void;
   children: ReactNode;
}

export const Form: FC<Props> = ({ onFinish, children }) => {

   const handleSubmitForm = (event: React.FormEvent<HTMLFormElement>) => {

      event.preventDefault();

      const data = new FormData(event.currentTarget);

      const values: any = {};

      data.forEach((value, key) => {
         values[key] = value;
      });

      onFinish(values);
   }

   return <form onSubmit={handleSubmitForm}>{children}</form>;
};